// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Object representing basic authentication credentials
    /// </summary>
    public partial class BasicCredentials
    {
        /// <summary>
        /// Initializes a new instance of the BasicCredentials class.
        /// </summary>
        public BasicCredentials() { }

        /// <summary>
        /// Initializes a new instance of the BasicCredentials class.
        /// </summary>
        public BasicCredentials(string username = default(string), string password = default(string))
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Username required to access the datasource
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Password required to access the datasource
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}