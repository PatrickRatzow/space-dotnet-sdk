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
    public sealed class KBFolderDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        [JsonPropertyName("parent")]
        public KBFolderDto? Parent { get; set; }
    
        [Required]
        [JsonPropertyName("subfolders")]
        public List<KBFolderDto> Subfolders { get; set; }
    
        [Required]
        [JsonPropertyName("articles")]
        public List<KBArticleDto> Articles { get; set; }
    
        [Required]
        [JsonPropertyName("book")]
        public KBBookDto Book { get; set; }
    
        [Required]
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
    
    }
    
}
