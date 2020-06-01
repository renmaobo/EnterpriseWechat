using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseWechat.Models.Contacts.Tags
{
    /// <summary>
    /// tag create model
    /// </summary>
    public class TagCreate
    {
        /// <summary>
        /// tag name
        /// </summary>
        [JsonProperty("tagname")]
        public string TagName { get; set; }

        /// <summary>
        /// tag id
        /// </summary>
        [JsonProperty("tagid")]
        public int TagId { get; set; }
    }
}
