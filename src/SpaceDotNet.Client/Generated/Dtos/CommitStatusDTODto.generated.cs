// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1850044+00:00
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
    public class CommitStatusDTODto
    {
        [Required]
        [JsonPropertyName("repository")]
        public string Repository { get; set; }        
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision { get; set; }        
        
        [Required]
        [JsonPropertyName("executionStatus")]
        public ExecutionStatus ExecutionStatus { get; set; }        
        
        [Required]
        [JsonPropertyName("url")]
        public string Url { get; set; }        
        
        [Required]
        [JsonPropertyName("externalServiceName")]
        public string ExternalServiceName { get; set; }        
        
        [Required]
        [JsonPropertyName("taskName")]
        public string TaskName { get; set; }        
        
        [Required]
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; }        
        
        [Required]
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
    }
    
}
