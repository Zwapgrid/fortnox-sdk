using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace FortnoxAPILibrary.Entities
{
    /// <inheritdoc />
    [XmlRoot(ElementName = "EmployeeSubset")]
    public class EmployeeSubset : Employee
    {
        /// <summary>
        /// Full url to employee
        /// </summary>
        [XmlAttribute(AttributeName = "url")]
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }
}
