// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Exporter.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeviceValue
    {
        /// <summary>
        /// Initializes a new instance of the DeviceValue class.
        /// </summary>
        public DeviceValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceValue class.
        /// </summary>
        public DeviceValue(string deviceName = default(string), double? usage = default(double?))
        {
            DeviceName = deviceName;
            Usage = usage;
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
        [JsonProperty(PropertyName = "usage")]
        public double? Usage { get; set; }

    }
}
