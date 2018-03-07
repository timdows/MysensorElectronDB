// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Proxy.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DomoticzValuesForCachingValue
    {
        /// <summary>
        /// Initializes a new instance of the DomoticzValuesForCachingValue
        /// class.
        /// </summary>
        public DomoticzValuesForCachingValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomoticzValuesForCachingValue
        /// class.
        /// </summary>
        public DomoticzValuesForCachingValue(long? deviceID = default(long?), double? currentWattValue = default(double?), double? todayKwhUsage = default(double?), System.DateTime? lastUpdate = default(System.DateTime?))
        {
            DeviceID = deviceID;
            CurrentWattValue = currentWattValue;
            TodayKwhUsage = todayKwhUsage;
            LastUpdate = lastUpdate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceID")]
        public long? DeviceID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentWattValue")]
        public double? CurrentWattValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "todayKwhUsage")]
        public double? TodayKwhUsage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdate")]
        public System.DateTime? LastUpdate { get; set; }

    }
}
