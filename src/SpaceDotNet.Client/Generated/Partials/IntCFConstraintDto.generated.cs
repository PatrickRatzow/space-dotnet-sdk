// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4814965+00:00
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

namespace SpaceDotNet.Client.IntCFConstraintExtensions
{
    public static class IntCFConstraintDtoPartialExtensions
    {
        public static Partial<IntCFConstraintDto> WithMin(this Partial<IntCFConstraintDto> it)
            => it.AddFieldName("min");
        
        public static Partial<IntCFConstraintDto> WithMax(this Partial<IntCFConstraintDto> it)
            => it.AddFieldName("max");
        
        public static Partial<IntCFConstraintDto> WithMessage(this Partial<IntCFConstraintDto> it)
            => it.AddFieldName("message");
        
    }
    
}
