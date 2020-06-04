using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>
    [Entity(SingularName = "PreDefinedAccount", PluralName = "PreDefinedAccounts")]
    public class PreDefinedAccount 
    {
        /// <remarks/>
        [JsonProperty]
        public string Account { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty]
        public string Name { get; private set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [ReadOnly]
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; private set; }
    }

    /// <remarks/>
    [Entity(SingularName = "PreDefinedAccount", PluralName = "PreDefinedAccounts")]
    public class PreDefinedAccountSubset
    {
        /// <remarks/>
        [JsonProperty]
        public string Account { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Name { get; set; }

        /// <remarks/>
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }
}
