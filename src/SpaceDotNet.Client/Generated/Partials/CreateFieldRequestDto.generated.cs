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

namespace SpaceDotNet.Client.CreateFieldRequestExtensions
{
    public static class CreateFieldRequestDtoPartialExtensions
    {
        public static Partial<CreateFieldRequestDto> WithName(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CreateFieldRequestDto> WithKey(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("key");
        
        public static Partial<CreateFieldRequestDto> WithType(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("type");
        
        public static Partial<CreateFieldRequestDto> WithType(this Partial<CreateFieldRequestDto> it, Func<Partial<CFTypeDto>, Partial<CFTypeDto>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<CFTypeDto>()));
        
        public static Partial<CreateFieldRequestDto> WithConstraint(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("constraint");
        
        public static Partial<CreateFieldRequestDto> WithConstraint(this Partial<CreateFieldRequestDto> it, Func<Partial<CFConstraintDto>, Partial<CFConstraintDto>> partialBuilder)
            => it.AddFieldName("constraint", partialBuilder(new Partial<CFConstraintDto>()));
        
        public static Partial<CreateFieldRequestDto> WithRequired(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("required");
        
        public static Partial<CreateFieldRequestDto> WithPrivate(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("private");
        
        public static Partial<CreateFieldRequestDto> WithAccess(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("access");
        
        public static Partial<CreateFieldRequestDto> WithAccess(this Partial<CreateFieldRequestDto> it, Func<Partial<AccessType>, Partial<AccessType>> partialBuilder)
            => it.AddFieldName("access", partialBuilder(new Partial<AccessType>()));
        
        public static Partial<CreateFieldRequestDto> WithDefaultValue(this Partial<CreateFieldRequestDto> it)
            => it.AddFieldName("defaultValue");
        
        public static Partial<CreateFieldRequestDto> WithDefaultValue(this Partial<CreateFieldRequestDto> it, Func<Partial<CFValueDto>, Partial<CFValueDto>> partialBuilder)
            => it.AddFieldName("defaultValue", partialBuilder(new Partial<CFValueDto>()));
        
    }
    
}
