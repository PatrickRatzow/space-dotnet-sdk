// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2180134+00:00
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
    public class HAEndpointDto
    {
        [Required]
        [JsonPropertyName("resource")]
        public HAResourceDto Resource { get; set; }        
        
        [Required]
        [JsonPropertyName("method")]
        public HAMethod Method { get; set; }        
        
        [Required]
        [JsonPropertyName("parameters")]
        public List<HAParameterDto> Parameters { get; set; }        
        
        [JsonPropertyName("requestBody")]
        public HATypeObjectDto? RequestBody { get; set; }        
        
        [JsonPropertyName("responseBody")]
        public HATypeDto? ResponseBody { get; set; }        
        
        [Required]
        [JsonPropertyName("path")]
        public HAPathDto Path { get; set; }        
        
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }        
        
        [JsonPropertyName("doc")]
        public string? Doc { get; set; }        
        
        [JsonPropertyName("deprecation")]
        public HADeprecationDto? Deprecation { get; set; }        
        
    }
    
}
