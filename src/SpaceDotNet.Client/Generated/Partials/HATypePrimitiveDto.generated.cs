// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4789680+00:00
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

namespace SpaceDotNet.Client.HATypePrimitiveExtensions
{
    public static class HATypePrimitiveDtoPartialExtensions
    {
        public static Partial<HATypePrimitiveDto> WithPrimitive(this Partial<HATypePrimitiveDto> it)
            => it.AddFieldName("primitive");
        
        public static Partial<HATypePrimitiveDto> WithNullable(this Partial<HATypePrimitiveDto> it)
            => it.AddFieldName("nullable");
        
        public static Partial<HATypePrimitiveDto> WithOptional(this Partial<HATypePrimitiveDto> it)
            => it.AddFieldName("optional");
        
    }
    
}
