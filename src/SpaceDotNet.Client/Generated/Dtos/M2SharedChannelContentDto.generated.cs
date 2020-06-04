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
    public sealed class M2SharedChannelContentDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        [Required]
        [JsonPropertyName("group")]
        public string Group { get; set; }
    
        [Required]
        [JsonPropertyName("access")]
        public M2Access Access { get; set; }
    
        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        [JsonPropertyName("membersCounter")]
        public int? MembersCounter { get; set; }
    
        [JsonPropertyName("iconId")]
        public string? IconId { get; set; }
    
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto NotificationDefaults { get; set; }
    
        [JsonPropertyName("teams")]
        public List<TDTeamDto>? Teams { get; set; }
    
        [JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }
    
    }
    
}
