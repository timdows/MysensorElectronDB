// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Proxy.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CurrentUsage
    {
        /// <summary>
        /// Initializes a new instance of the CurrentUsage class.
        /// </summary>
        public CurrentUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CurrentUsage class.
        /// </summary>
        public CurrentUsage(string deviceName = default(string), double? currentWattValue = default(double?), double? todayKwhUsage = default(double?))
        {
            DeviceName = deviceName;
            CurrentWattValue = currentWattValue;
            TodayKwhUsage = todayKwhUsage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentWattValue")]
        public double? CurrentWattValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "todayKwhUsage")]
        public double? TodayKwhUsage { get; set; }

    }
}
