// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4542982+00:00
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

namespace SpaceDotNet.Client.DTORightsGroupExtensions
{
    public static class DTORightsGroupDtoPartialExtensions
    {
        public static Partial<DTORightsGroupDto> WithTitle(this Partial<DTORightsGroupDto> it)
            => it.AddFieldName("title");
        
        public static Partial<DTORightsGroupDto> WithPriority(this Partial<DTORightsGroupDto> it)
            => it.AddFieldName("priority");
        
        public static Partial<DTORightsGroupDto> WithRights(this Partial<DTORightsGroupDto> it)
            => it.AddFieldName("rights");
        
        public static Partial<DTORightsGroupDto> WithRights(this Partial<DTORightsGroupDto> it, Func<Partial<DTORightDto>, Partial<DTORightDto>> partialBuilder)
            => it.AddFieldName("rights", partialBuilder(new Partial<DTORightDto>()));
        
    }
    
}
