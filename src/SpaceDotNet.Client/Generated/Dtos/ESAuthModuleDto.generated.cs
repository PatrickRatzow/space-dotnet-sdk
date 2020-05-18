// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1933582+00:00
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
    public class ESAuthModuleDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("key")]
        public string Key { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [Required]
        [JsonPropertyName("ordinal")]
        public int Ordinal { get; set; }        
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }        
        
        [JsonPropertyName("iconDataURI")]
        public string? IconDataURI { get; set; }        
        
        [Required]
        [JsonPropertyName("settings")]
        public ESAuthModuleSettingsDto Settings { get; set; }        
        
    }
    
}
