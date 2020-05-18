// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5169732+00:00
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

namespace SpaceDotNet.Client.RecurrenceRuleExtensions
{
    public static class RecurrenceRuleDtoPartialExtensions
    {
        public static Partial<RecurrenceRuleDto> WithFreq(this Partial<RecurrenceRuleDto> it)
            => it.AddFieldName("freq");
        
        public static Partial<RecurrenceRuleDto> WithFreq(this Partial<RecurrenceRuleDto> it, Func<Partial<RecurrenceRuleFreqDto>, Partial<RecurrenceRuleFreqDto>> partialBuilder)
            => it.AddFieldName("freq", partialBuilder(new Partial<RecurrenceRuleFreqDto>()));
        
        public static Partial<RecurrenceRuleDto> WithEnds(this Partial<RecurrenceRuleDto> it)
            => it.AddFieldName("ends");
        
        public static Partial<RecurrenceRuleDto> WithEnds(this Partial<RecurrenceRuleDto> it, Func<Partial<RecurrenceRuleEndsDto>, Partial<RecurrenceRuleEndsDto>> partialBuilder)
            => it.AddFieldName("ends", partialBuilder(new Partial<RecurrenceRuleEndsDto>()));
        
    }
    
}
