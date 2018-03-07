// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Proxy.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DomoticzMotionDetection
    {
        /// <summary>
        /// Initializes a new instance of the DomoticzMotionDetection class.
        /// </summary>
        public DomoticzMotionDetection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomoticzMotionDetection class.
        /// </summary>
        public DomoticzMotionDetection(string data = default(string), System.DateTime? date = default(System.DateTime?), int? level = default(int?), string status = default(string))
        {
            Data = data;
            Date = date;
            Level = level;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public int? Level { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
