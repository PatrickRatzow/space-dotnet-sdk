// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5595426+00:00
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

namespace SpaceDotNet.Client.UpdateValueRequestExtensions
{
    public static class UpdateValueRequestDtoPartialExtensions
    {
        public static Partial<UpdateValueRequestDto> WithValues(this Partial<UpdateValueRequestDto> it)
            => it.AddFieldName("values");
        
        public static Partial<UpdateValueRequestDto> WithValues(this Partial<UpdateValueRequestDto> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("values", partialBuilder(new Partial<CustomFieldValueDto>()));
        
    }
    
}
