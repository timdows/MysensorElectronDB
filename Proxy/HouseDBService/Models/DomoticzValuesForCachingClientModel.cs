// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Proxy.HouseDBService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DomoticzValuesForCachingClientModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DomoticzValuesForCachingClientModel class.
        /// </summary>
        public DomoticzValuesForCachingClientModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DomoticzValuesForCachingClientModel class.
        /// </summary>
        public DomoticzValuesForCachingClientModel(System.DateTime? dateTime = default(System.DateTime?), DomoticzValuesForCachingValue p1Values = default(DomoticzValuesForCachingValue), IList<DomoticzValuesForCachingValue> domoticzValuesForCachingValues = default(IList<DomoticzValuesForCachingValue>))
        {
            DateTime = dateTime;
            P1Values = p1Values;
            DomoticzValuesForCachingValues = domoticzValuesForCachingValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public System.DateTime? DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "p1Values")]
        public DomoticzValuesForCachingValue P1Values { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domoticzValuesForCachingValues")]
        public IList<DomoticzValuesForCachingValue> DomoticzValuesForCachingValues { get; set; }

    }
}
