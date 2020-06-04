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
    public sealed class GitCommitInfoDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        [Required]
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
        [Required]
        [JsonPropertyName("authorDate")]
        public long AuthorDate { get; set; }
    
        [Required]
        [JsonPropertyName("commitDate")]
        public long CommitDate { get; set; }
    
        [Required]
        [JsonPropertyName("author")]
        public GitAuthorInfoDto Author { get; set; }
    
        [Required]
        [JsonPropertyName("committer")]
        public GitAuthorInfoDto Committer { get; set; }
    
        [JsonPropertyName("authorProfile")]
        public TDMemberProfileDto? AuthorProfile { get; set; }
    
        [Required]
        [JsonPropertyName("parents")]
        public List<string> Parents { get; set; }
    
        [Required]
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    
        [Required]
        [JsonPropertyName("branches")]
        public List<BranchInfoDto> Branches { get; set; }
    
        [Required]
        [JsonPropertyName("heads")]
        public List<string> Heads { get; set; }
    
    }
    
}
