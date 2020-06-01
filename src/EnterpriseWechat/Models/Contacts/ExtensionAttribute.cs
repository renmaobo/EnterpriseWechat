using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseWechat.Models.Contacts.Base
{
    /// <summary>
    /// extension attribute
    /// </summary>
    public class ExtensionAttribute
    {
        public ExtensionAttribute() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">name value</param>
        /// <param name="text">text message</param>
        public ExtensionAttribute(string name, TextBody text)
        {
            this.Type = 0;
            this.Name = name;
            this.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">name value</param>
        /// <param name="web">web info</param>
        public ExtensionAttribute(string name, WebBody web)
        {
            this.Type = 1;
            this.Name = name;
            this.Web = web;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">name value</param>
        /// <param name="miniProgram">mini program info</param>
        public ExtensionAttribute(string name, MiniProgramBody miniProgram)
        {
            this.Type = 2;
            this.Name = name;
            this.MiniProgram = miniProgram;
        }

        /// <summary>
        /// type value
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// name value
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// text content
        /// </summary>
        [JsonProperty("text")]
        public TextBody Text { get; set; }

        /// <summary>
        /// web content
        /// </summary>
        [JsonProperty("web")]
        public WebBody Web { get; set; }

        /// <summary>
        /// mini program content
        /// </summary>
        [JsonProperty("miniprogram")]
        public MiniProgramBody MiniProgram { get; set; }

        /// <summary>
        /// text body
        /// </summary>
        public class TextBody
        {
            /// <summary>
            /// text value
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; }
        }

        /// <summary>
        /// web info body
        /// </summary>
        public class WebBody
        {
            /// <summary>
            /// visit url address
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// title content
            /// </summary>
            [JsonProperty("title")]
            public string Title { get; set; }
        }

        /// <summary>
        /// mini program body
        /// </summary>
        public class MiniProgramBody
        {
            /// <summary>
            /// application id
            /// </summary>
            [JsonProperty("appid")]
            public string AppId { get; set; }

            /// <summary>
            /// page path
            /// </summary>
            [JsonProperty("pagepath")]
            public string PagePath { get; set; }

            /// <summary>
            /// title content
            /// </summary>
            [JsonProperty("title")]
            public string Title { get; set; }
        }
    }
}
