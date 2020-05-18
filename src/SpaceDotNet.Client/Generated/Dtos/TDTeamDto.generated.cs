// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2774105+00:00
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
    public class TDTeamDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }        
        
        [JsonPropertyName("parent")]
        public TDTeamDto? Parent { get; set; }        
        
        [JsonPropertyName("emails")]
        public List<string>? Emails { get; set; }        
        
        [JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [JsonPropertyName("disbanded")]
        public bool? Disbanded { get; set; }        
        
        [JsonPropertyName("disbandedAt")]
        public SpaceDate? DisbandedAt { get; set; }        
        
        [Required]
        [JsonPropertyName("memberships")]
        public List<TDMembershipDto> Memberships { get; set; }        
        
    }
    
}
