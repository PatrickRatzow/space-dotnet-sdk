// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2159680+00:00
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
    public class GitCommitterProfileDto
    {
        [Required]
        [JsonPropertyName("author")]
        public string Author { get; set; }        
        
        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }        
        
        [JsonPropertyName("profile")]
        public TDMemberProfileDto? Profile { get; set; }        
        
    }
    
}
