// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2528266+00:00
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
    public class NonWorkingDaysDto
    {
        [Required]
        [JsonPropertyName("since")]
        public SpaceDate Since { get; set; }        
        
        [Required]
        [JsonPropertyName("till")]
        public SpaceDate Till { get; set; }        
        
        [Required]
        [JsonPropertyName("startsEarlier")]
        public bool StartsEarlier { get; set; }        
        
        [Required]
        [JsonPropertyName("endsLater")]
        public bool EndsLater { get; set; }        
        
    }
    
}
