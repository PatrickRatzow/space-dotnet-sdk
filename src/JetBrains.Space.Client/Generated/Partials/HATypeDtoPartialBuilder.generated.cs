// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.HATypeDtoPartialBuilder
{
    public static class HATypeDtoPartialExtensions
    {
        public static Partial<HATypeDto> WithDto(this Partial<HATypeDto> it)
            => it.AddFieldName("dto");
        
        public static Partial<HATypeDto> WithDto(this Partial<HATypeDto> it, Func<Partial<HADto>, Partial<HADto>> partialBuilder)
            => it.AddFieldName("dto", partialBuilder(new Partial<HADto>(it)));
        
        public static Partial<HATypeDto> WithIsNullable(this Partial<HATypeDto> it)
            => it.AddFieldName("nullable");
        
    }
    
}
