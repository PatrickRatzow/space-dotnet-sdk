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
    public sealed class CodeReviewDiscussionRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        [Required]
        [JsonPropertyName("review")]
        public CodeReviewRecordDto Review { get; set; }
    
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created { get; set; }
    
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel { get; set; }
    
        [Required]
        [JsonPropertyName("resolved")]
        public bool Resolved { get; set; }
    
    }
    
}
