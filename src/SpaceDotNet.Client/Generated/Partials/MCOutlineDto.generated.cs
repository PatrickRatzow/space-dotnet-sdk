// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5023455+00:00
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

namespace SpaceDotNet.Client.MCOutlineExtensions
{
    public static class MCOutlineDtoPartialExtensions
    {
        public static Partial<MCOutlineDto> WithIcon(this Partial<MCOutlineDto> it)
            => it.AddFieldName("icon");
        
        public static Partial<MCOutlineDto> WithIcon(this Partial<MCOutlineDto> it, Func<Partial<MCElementDto>, Partial<MCElementDto>> partialBuilder)
            => it.AddFieldName("icon", partialBuilder(new Partial<MCElementDto>()));
        
        public static Partial<MCOutlineDto> WithText(this Partial<MCOutlineDto> it)
            => it.AddFieldName("text");
        
        public static Partial<MCOutlineDto> WithText(this Partial<MCOutlineDto> it, Func<Partial<MCTextDto>, Partial<MCTextDto>> partialBuilder)
            => it.AddFieldName("text", partialBuilder(new Partial<MCTextDto>()));
        
    }
    
}
