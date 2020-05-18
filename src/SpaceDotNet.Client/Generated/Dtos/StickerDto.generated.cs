// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.2704020+00:00
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
    public class StickerDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }        
        
        [JsonPropertyName("attachmentId")]
        public string? AttachmentId { get; set; }        
        
        [JsonPropertyName("width")]
        public int? Width { get; set; }        
        
        [JsonPropertyName("height")]
        public int? Height { get; set; }        
        
        [JsonPropertyName("variants")]
        public List<StickerVariantDto>? Variants { get; set; }        
        
        [JsonPropertyName("animated")]
        public bool? Animated { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
    }
    
}
