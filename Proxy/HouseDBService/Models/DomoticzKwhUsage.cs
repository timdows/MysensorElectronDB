// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Proxy.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DomoticzKwhUsage
    {
        /// <summary>
        /// Initializes a new instance of the DomoticzKwhUsage class.
        /// </summary>
        public DomoticzKwhUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomoticzKwhUsage class.
        /// </summary>
        public DomoticzKwhUsage(double? c = default(double?), System.DateTime? d = default(System.DateTime?), double? v = default(double?), double? usage = default(double?), System.DateTime? date = default(System.DateTime?))
        {
            C = c;
            D = d;
            V = v;
            Usage = usage;
            Date = date;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "c")]
        public double? C { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "d")]
        public System.DateTime? D { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "v")]
        public double? V { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public double? Usage { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; private set; }

    }
}
