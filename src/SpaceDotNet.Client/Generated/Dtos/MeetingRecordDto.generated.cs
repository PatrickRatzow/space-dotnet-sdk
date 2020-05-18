// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2504174+00:00
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
    public class MeetingRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("starts")]
        public SpaceTime Starts { get; set; }        
        
        [Required]
        [JsonPropertyName("finishes")]
        public SpaceTime Finishes { get; set; }        
        
        [JsonPropertyName("timezone")]
        public ATimeZoneDto? Timezone { get; set; }        
        
        [Required]
        [JsonPropertyName("allDay")]
        public bool AllDay { get; set; }        
        
        [Required]
        [JsonPropertyName("rooms")]
        public List<TDLocationDto> Rooms { get; set; }        
        
        [Required]
        [JsonPropertyName("participants")]
        public List<ParticipantDto> Participants { get; set; }        
        
        [JsonPropertyName("article")]
        public ArticleRecordDto? Article { get; set; }        
        
    }
    
}
