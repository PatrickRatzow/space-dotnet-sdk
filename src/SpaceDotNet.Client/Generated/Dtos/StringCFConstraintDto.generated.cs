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
    public sealed class StringCFConstraintDto
         : CFConstraintDto, IClassNameConvertible
    {
        [JsonPropertyName("min")]
        public int? Min { get; set; }
    
        [JsonPropertyName("max")]
        public int? Max { get; set; }
    
        [JsonPropertyName("pattern")]
        public string? Pattern { get; set; }
    
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    
    }
    
}
