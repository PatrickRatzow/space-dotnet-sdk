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
    public sealed class PRProjectDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        [Required]
        [JsonPropertyName("key")]
        public ProjectKeyDto Key { get; set; }
    
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        [Required]
        [JsonPropertyName("private")]
        public bool Private { get; set; }
    
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    
        [JsonPropertyName("icon")]
        public string? Icon { get; set; }
    
        [JsonPropertyName("latestRepositoryActivity")]
        public SpaceTime? LatestRepositoryActivity { get; set; }
    
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    
        [Required]
        [JsonPropertyName("adminProfiles")]
        public List<TDMemberProfileDto> AdminProfiles { get; set; }
    
        [Required]
        [JsonPropertyName("adminTeams")]
        public List<TDTeamDto> AdminTeams { get; set; }
    
        [Required]
        [JsonPropertyName("memberProfiles")]
        public List<TDMemberProfileDto> MemberProfiles { get; set; }
    
        [Required]
        [JsonPropertyName("memberTeams")]
        public List<TDTeamDto> MemberTeams { get; set; }
    
        [Required]
        [JsonPropertyName("repos")]
        public List<PRRepositoryInfoDto> Repos { get; set; }
    
        [Required]
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    
    }
    
}
