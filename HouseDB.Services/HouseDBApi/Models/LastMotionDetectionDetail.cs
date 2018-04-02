// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HouseDB.Services.HouseDBApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LastMotionDetectionDetail
    {
        /// <summary>
        /// Initializes a new instance of the LastMotionDetectionDetail class.
        /// </summary>
        public LastMotionDetectionDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LastMotionDetectionDetail class.
        /// </summary>
        public LastMotionDetectionDetail(string deviceName = default(string), System.DateTime? lastDetection = default(System.DateTime?), System.DateTime? previousDetection = default(System.DateTime?), int? detectionsToday = default(int?))
        {
            DeviceName = deviceName;
            LastDetection = lastDetection;
            PreviousDetection = previousDetection;
            DetectionsToday = detectionsToday;
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
        [JsonProperty(PropertyName = "lastDetection")]
        public System.DateTime? LastDetection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previousDetection")]
        public System.DateTime? PreviousDetection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "detectionsToday")]
        public int? DetectionsToday { get; set; }

    }
}
