// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5378798+00:00
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

namespace SpaceDotNet.Client.WorkingDaysSpecExtensions
{
    public static class WorkingDaysSpecDtoPartialExtensions
    {
        public static Partial<WorkingDaysSpecDto> WithDays(this Partial<WorkingDaysSpecDto> it)
            => it.AddFieldName("days");
        
        public static Partial<WorkingDaysSpecDto> WithDays(this Partial<WorkingDaysSpecDto> it, Func<Partial<WorkdayDto>, Partial<WorkdayDto>> partialBuilder)
            => it.AddFieldName("days", partialBuilder(new Partial<WorkdayDto>()));
        
    }
    
}
