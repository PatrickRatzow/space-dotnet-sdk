// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2173856+00:00
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
    public class HADtoDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [Required]
        [JsonPropertyName("fields")]
        public List<HADtoFieldDto> Fields { get; set; }        
        
        [Required]
        [JsonPropertyName("hierarchyRole")]
        public HierarchyRole HierarchyRole { get; set; }        
        
        [JsonPropertyName("extends")]
        public HADtoDto? Extends { get; set; }        
        
        [Required]
        [JsonPropertyName("implements")]
        public List<HADtoDto> Implements { get; set; }        
        
        [Required]
        [JsonPropertyName("inheritors")]
        public List<HADtoDto> Inheritors { get; set; }        
        
        [JsonPropertyName("deprecation")]
        public HADeprecationDto? Deprecation { get; set; }        
        
        [Required]
        [JsonPropertyName("record")]
        public bool Record { get; set; }        
        
    }
    
}
