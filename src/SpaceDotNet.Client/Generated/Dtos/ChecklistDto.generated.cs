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
    public sealed class ChecklistDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    
        [JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }
    
        [JsonPropertyName("project")]
        public PRProjectDto? Project { get; set; }
    
        [JsonPropertyName("owner")]
        public TDMemberProfileDto? Owner { get; set; }
    
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        [JsonPropertyName("root")]
        public PlanItemDto? Root { get; set; }
    
        [JsonPropertyName("rootTag")]
        public PlanningTagDto? RootTag { get; set; }
    
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    
        [Required]
        [JsonPropertyName("totalItemsCount")]
        public int TotalItemsCount { get; set; }
    
        [Required]
        [JsonPropertyName("doneItemsCount")]
        public int DoneItemsCount { get; set; }
    
        [JsonPropertyName("updatedTime")]
        public SpaceTime? UpdatedTime { get; set; }
    
    }
    
}
