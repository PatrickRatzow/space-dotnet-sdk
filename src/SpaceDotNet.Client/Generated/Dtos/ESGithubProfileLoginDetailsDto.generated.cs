// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1961398+00:00
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
    public class ESGithubProfileLoginDetailsDto
         : ESProfileLoginDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [JsonPropertyName("login")]
        public string? Login { get; set; }        
        
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }        
        
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }        
        
        [JsonPropertyName("email")]
        public string? Email { get; set; }        
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool EmailVerified { get; set; }        
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }        
        
        [JsonPropertyName("organizations")]
        public List<string>? Organizations { get; set; }        
        
    }
    
}
