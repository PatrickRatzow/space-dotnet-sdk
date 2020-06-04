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
    public sealed class HAModelDto
    {
        [Required]
        [JsonPropertyName("dto")]
        public List<HADtoDto> Dto { get; set; }
    
        [Required]
        [JsonPropertyName("enums")]
        public List<HAEnumDto> Enums { get; set; }
    
        [Required]
        [JsonPropertyName("resources")]
        public List<HAResourceDto> Resources { get; set; }
    
        [Required]
        [JsonPropertyName("allResources")]
        public List<HAResourceDto> AllResources { get; set; }
    
    }
    
}
