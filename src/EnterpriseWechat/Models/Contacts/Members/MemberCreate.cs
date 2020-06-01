using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseWechat.Models.Contacts
{
    /// <summary>
    /// enterprise member create
    /// </summary>
    public class MemberCreate
    {
        /// <summary>
        /// user id(allow write user account)
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// user name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// user aliase
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// mobile phone
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// at department code
        /// </summary>
        [JsonProperty("department")]
        public List<int> Department { get; set; }

        /// <summary>
        /// user sort
        /// </summary>
        [JsonProperty("order")]
        public List<int> Order { get; set; }

        /// <summary>
        /// user position name
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// user gender
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// leader mark for department code
        /// </summary>
        [JsonProperty("is_leader_in_dept")]
        public List<int> IsLeaderInDept { get; set; }

        /// <summary>
        /// user status
        /// </summary>
        [JsonProperty("enable")]
        public int Enable { get; set; }

        /// <summary>
        /// user avatar mediaid
        /// </summary>
        [JsonProperty("avatar_mediaid")]
        public string AvatarMediaid { get; set; }

        /// <summary>
        /// user telphone
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// street address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// mian department code
        /// </summary>
        [JsonProperty("main_department")]
        public int MainDepartment { get; set; }

        /// <summary>
        /// extension attributes
        /// </summary>
        [JsonProperty("extattr")]
        public ExtensionAttributes Extattr { get; set; }

        /// <summary>
        /// invite user, default value is true
        /// </summary>
        [JsonProperty("to_invite")]
        public bool ToInvite { get; set; } = true;

        /// <summary>
        /// external position name
        /// </summary>
        [JsonProperty("external_position")]
        public string ExternalPosition { get; set; }

        /// <summary>
        /// external profile
        /// </summary>
        [JsonProperty("external_profile")]
        public ExternalProfile ExternalProfile { get; set; }
    }

    /// <summary>
    /// external profile
    /// </summary>
    public class ExternalProfile
    {
        /// <summary>
        /// external enterprise name
        /// </summary>
        [JsonProperty("external_corp_name")]
        public string ExternalCorpName { get; set; }

        /// <summary>
        /// external extension attribute
        /// </summary>
        [JsonProperty("external_attr")]
        public List<Base.ExtensionAttribute> ExternalAttr { get; set; }
    }

    /// <summary>
    /// extension attributes
    /// </summary>
    public class ExtensionAttributes
    {
        /// <summary>
        /// attributes
        /// </summary>
        [JsonProperty("attrs")]
        public List<Base.ExtensionAttribute> Attributes { get; set; }
    }
}
