using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseWechat.Models.Contacts.Departments
{
    /// <summary>
    /// department create model
    /// </summary>
    public class DepartmentCreate
    {
        /// <summary>
        /// department name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// department english name
        /// </summary>
        [JsonProperty("name_en")]
        public string NameEn { get; set; }

        /// <summary>
        /// parent departemnt id
        /// </summary>
        [JsonProperty("parentid")]
        public int ParentId { get; set; }

        /// <summary>
        /// sort id
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// department id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
