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
    public sealed class BlogPublicationDetailsDto
         : PublicationDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [JsonPropertyName("teamId")]
        public TDTeamDto? TeamId { get; set; }
    
        [JsonPropertyName("teams")]
        public List<TDTeamDto>? Teams { get; set; }
    
        [JsonPropertyName("locationId")]
        public TDLocationDto? LocationId { get; set; }
    
        [JsonPropertyName("locations")]
        public List<TDLocationDto>? Locations { get; set; }
    
        [JsonPropertyName("event")]
        public CalendarEventDto? Event { get; set; }
    
        [JsonPropertyName("article")]
        public ArticleRecordDto? Article { get; set; }
    
    }
    
}
