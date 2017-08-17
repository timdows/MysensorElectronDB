﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using HouseDB.Data;
using MySQL.Data.Entity.Extensions;
using Newtonsoft.Json;
using Serilog;
using HouseDB.Data.Settings;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;

namespace HouseDB
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.Prod.json", optional: false, reloadOnChange: true)
				.AddEnvironmentVariables();
			Configuration = builder.Build();

			builder.AddEntityFrameworkConfig(options => options.UseMySQL(Configuration["Database:ConnectionString"]));
			Configuration = builder.Build();

			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Debug()
				.Enrich.FromLogContext()
				.WriteTo.LiterateConsole()
				.ReadFrom.Configuration(Configuration)
				.CreateLogger();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().AddJsonOptions(options => {
				options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			});

			services.AddCors();

			//services.AddAuthorization(options =>
			//{
			//	options.AddPolicy("houseDB", policyRead =>
			//	{
			//		policyRead.RequireClaim("scope", "houseDB");
			//	});
			//	options.AddPolicy("houseDBWrite", policyRead =>
			//	{
			//		policyRead.RequireClaim("scope", "houseDB.write");
			//	});
			//});

			var connection = Configuration["Database:ConnectionString"];
			services.AddDbContext<DataContext>(options => options.UseMySQL(connection));
			services.Configure<VeraSettings>(Configuration.GetSection("VeraSettings"));
			services.Configure<DataMineSettings>(Configuration.GetSection("DataMineSettings"));
			services.Configure<RaspicamSettings>(Configuration.GetSection("RaspicamSettings"));
			services.Configure<DomoticzSettings>(Configuration.GetSection("DomoticzSettings"));

			// Register the Swagger generator, defining one or more Swagger documents
			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new Info { Title = "HouseDB API", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IApplicationLifetime appLifetime)
		{
			loggerFactory.AddSerilog();
			appLifetime.ApplicationStopped.Register(Log.CloseAndFlush);

			app.UseCors(builder => builder.AllowAnyOrigin());

			app.UseIdentityServerAuthentication(new IdentityServerAuthenticationOptions
			{
				Authority = "https://tis.timdows.com",
				RequireHttpsMetadata = true,
				ApiName = "houseDB",
				AllowedScopes = new List<string> { "houseDB" }
			});

			app.UseMvc(routes =>
			{
				routes.MapRoute(name: "jsonRoute", template: "{controller}/{action}.json");
				routes.MapRoute(name: "postRoute", template: "{controller}/{action}");
			});

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "HouseDB API v1");
			});
		}
	}
}
