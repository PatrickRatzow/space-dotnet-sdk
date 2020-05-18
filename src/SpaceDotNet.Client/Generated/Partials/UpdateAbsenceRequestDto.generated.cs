// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5527915+00:00
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

namespace SpaceDotNet.Client.UpdateAbsenceRequestExtensions
{
    public static class UpdateAbsenceRequestDtoPartialExtensions
    {
        public static Partial<UpdateAbsenceRequestDto> WithMember(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("member");
        
        public static Partial<UpdateAbsenceRequestDto> WithReason(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("reason");
        
        public static Partial<UpdateAbsenceRequestDto> WithDescription(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("description");
        
        public static Partial<UpdateAbsenceRequestDto> WithLocation(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("location");
        
        public static Partial<UpdateAbsenceRequestDto> WithSince(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("since");
        
        public static Partial<UpdateAbsenceRequestDto> WithTill(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("till");
        
        public static Partial<UpdateAbsenceRequestDto> WithAvailable(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("available");
        
        public static Partial<UpdateAbsenceRequestDto> WithIcon(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("icon");
        
        public static Partial<UpdateAbsenceRequestDto> WithCustomFieldValues(this Partial<UpdateAbsenceRequestDto> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<UpdateAbsenceRequestDto> WithCustomFieldValues(this Partial<UpdateAbsenceRequestDto> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValueDto>()));
        
    }
    
}
