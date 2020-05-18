// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5025217+00:00
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

namespace SpaceDotNet.Client.MCSectionExtensions
{
    public static class MCSectionDtoPartialExtensions
    {
        public static Partial<MCSectionDto> WithHeader(this Partial<MCSectionDto> it)
            => it.AddFieldName("header");
        
        public static Partial<MCSectionDto> WithHeader(this Partial<MCSectionDto> it, Func<Partial<MCTextDto>, Partial<MCTextDto>> partialBuilder)
            => it.AddFieldName("header", partialBuilder(new Partial<MCTextDto>()));
        
        public static Partial<MCSectionDto> WithElements(this Partial<MCSectionDto> it)
            => it.AddFieldName("elements");
        
        public static Partial<MCSectionDto> WithElements(this Partial<MCSectionDto> it, Func<Partial<MCElementDto>, Partial<MCElementDto>> partialBuilder)
            => it.AddFieldName("elements", partialBuilder(new Partial<MCElementDto>()));
        
        public static Partial<MCSectionDto> WithFooter(this Partial<MCSectionDto> it)
            => it.AddFieldName("footer");
        
        public static Partial<MCSectionDto> WithFooter(this Partial<MCSectionDto> it, Func<Partial<MCTextDto>, Partial<MCTextDto>> partialBuilder)
            => it.AddFieldName("footer", partialBuilder(new Partial<MCTextDto>()));
        
    }
    
}
