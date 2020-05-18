// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5539695+00:00
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

namespace SpaceDotNet.Client.UpdateFieldRequestExtensions
{
    public static class UpdateFieldRequestDtoPartialExtensions
    {
        public static Partial<UpdateFieldRequestDto> WithName(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("name");
        
        public static Partial<UpdateFieldRequestDto> WithKey(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("key");
        
        public static Partial<UpdateFieldRequestDto> WithConstraint(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("constraint");
        
        public static Partial<UpdateFieldRequestDto> WithConstraint(this Partial<UpdateFieldRequestDto> it, Func<Partial<CFConstraintDto>, Partial<CFConstraintDto>> partialBuilder)
            => it.AddFieldName("constraint", partialBuilder(new Partial<CFConstraintDto>()));
        
        public static Partial<UpdateFieldRequestDto> WithRequired(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("required");
        
        public static Partial<UpdateFieldRequestDto> WithPrivate(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("private");
        
        public static Partial<UpdateFieldRequestDto> WithAccess(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("access");
        
        public static Partial<UpdateFieldRequestDto> WithDefaultValue(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("defaultValue");
        
        public static Partial<UpdateFieldRequestDto> WithDefaultValue(this Partial<UpdateFieldRequestDto> it, Func<Partial<CFValueDto>, Partial<CFValueDto>> partialBuilder)
            => it.AddFieldName("defaultValue", partialBuilder(new Partial<CFValueDto>()));
        
        public static Partial<UpdateFieldRequestDto> WithEnumValues(this Partial<UpdateFieldRequestDto> it)
            => it.AddFieldName("enumValues");
        
        public static Partial<UpdateFieldRequestDto> WithEnumValues(this Partial<UpdateFieldRequestDto> it, Func<Partial<EnumValueDataDto>, Partial<EnumValueDataDto>> partialBuilder)
            => it.AddFieldName("enumValues", partialBuilder(new Partial<EnumValueDataDto>()));
        
    }
    
}
