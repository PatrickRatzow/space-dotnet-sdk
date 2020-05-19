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

namespace SpaceDotNet.Client.CustomFieldValueExtensions
{
    public static class CustomFieldValueDtoPartialExtensions
    {
        public static Partial<CustomFieldValueDto> WithField(this Partial<CustomFieldValueDto> it)
            => it.AddFieldName("field");
        
        public static Partial<CustomFieldValueDto> WithField(this Partial<CustomFieldValueDto> it, Func<Partial<CustomFieldDto>, Partial<CustomFieldDto>> partialBuilder)
            => it.AddFieldName("field", partialBuilder(new Partial<CustomFieldDto>()));
        
        public static Partial<CustomFieldValueDto> WithValue(this Partial<CustomFieldValueDto> it)
            => it.AddFieldName("value");
        
        public static Partial<CustomFieldValueDto> WithValue(this Partial<CustomFieldValueDto> it, Func<Partial<CFValueDto>, Partial<CFValueDto>> partialBuilder)
            => it.AddFieldName("value", partialBuilder(new Partial<CFValueDto>()));
        
    }
    
}