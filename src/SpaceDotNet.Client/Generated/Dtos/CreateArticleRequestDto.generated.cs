// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4085794+00:00
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
    public class CreateArticleRequestDto
    {
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
        [Required]
        [JsonPropertyName("content")]
        public string Content { get; set; }        
        
        [JsonPropertyName("created")]
        public SpaceTime? Created { get; set; }        
        
        [JsonPropertyName("team")]
        public string? Team { get; set; }        
        
        [JsonPropertyName("teams")]
        public List<string>? Teams { get; set; }        
        
        [JsonPropertyName("location")]
        public string? Location { get; set; }        
        
        [JsonPropertyName("locations")]
        public List<string>? Locations { get; set; }        
        
    }
    
}
