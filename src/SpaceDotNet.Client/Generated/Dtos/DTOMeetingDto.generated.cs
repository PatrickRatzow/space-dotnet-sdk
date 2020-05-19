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
    public class DTOMeetingDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
        [Required]
        [JsonPropertyName("locations")]
        public List<TDLocationDto> Locations { get; set; }        
        
        [Required]
        [JsonPropertyName("profiles")]
        public List<TDMemberProfileDto> Profiles { get; set; }        
        
        [Required]
        [JsonPropertyName("teams")]
        public List<TDTeamDto> Teams { get; set; }        
        
        [Required]
        [JsonPropertyName("occurrenceRule")]
        public CalendarEventSpecDto OccurrenceRule { get; set; }        
        
        [Required]
        [JsonPropertyName("origin")]
        public MeetingOrigin Origin { get; set; }        
        
        [JsonPropertyName("googleMeetLink")]
        public string? GoogleMeetLink { get; set; }        
        
        [Required]
        [JsonPropertyName("visibility")]
        public MeetingVisibility Visibility { get; set; }        
        
        [Required]
        [JsonPropertyName("modificationPreference")]
        public MeetingModificationPreference ModificationPreference { get; set; }        
        
        [JsonPropertyName("joiningPreference")]
        public MeetingJoiningPreference? JoiningPreference { get; set; }        
        
        [Required]
        [JsonPropertyName("organizer")]
        public MeetingOrganizerDto Organizer { get; set; }        
        
        [Required]
        [JsonPropertyName("etag")]
        public long Etag { get; set; }        
        
        [JsonPropertyName("googleEventId")]
        public string? GoogleEventId { get; set; }        
        
        [Required]
        [JsonPropertyName("privateDataSubstituted")]
        public bool PrivateDataSubstituted { get; set; }        
        
        [Required]
        [JsonPropertyName("canModify")]
        public bool CanModify { get; set; }        
        
        [Required]
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }        
        
        [Required]
        [JsonPropertyName("canJoin")]
        public bool CanJoin { get; set; }        
        
        [JsonPropertyName("externalParticipants")]
        public List<string>? ExternalParticipants { get; set; }        
        
    }
    
}