// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class M2ChannelContactThreadDto
         : M2ChannelContactInfoDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("parent")]
        public M2ChannelRecordDto Parent { get; set; }        
        
        [JsonPropertyName("text")]
        public string? Text { get; set; }        
        
        [JsonPropertyName("messageId")]
        public string? MessageId { get; set; }        
        
        [JsonPropertyName("author")]
        public TDMemberProfileDto? Author { get; set; }        
        
        [JsonPropertyName("messageAuthor")]
        public CPrincipalDto? MessageAuthor { get; set; }        
        
        [JsonPropertyName("attachments")]
        public string? Attachments { get; set; }        
        
    }
    
}