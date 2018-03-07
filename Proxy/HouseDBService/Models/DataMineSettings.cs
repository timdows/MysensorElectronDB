// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Proxy.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DataMineSettings
    {
        /// <summary>
        /// Initializes a new instance of the DataMineSettings class.
        /// </summary>
        public DataMineSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataMineSettings class.
        /// </summary>
        public DataMineSettings(int? powerImport1Channel = default(int?), int? powerImport2Channel = default(int?))
        {
            PowerImport1Channel = powerImport1Channel;
            PowerImport2Channel = powerImport2Channel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "powerImport1Channel")]
        public int? PowerImport1Channel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "powerImport2Channel")]
        public int? PowerImport2Channel { get; set; }

    }
}
