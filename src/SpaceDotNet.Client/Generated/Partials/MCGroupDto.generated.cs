// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5015614+00:00
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

namespace SpaceDotNet.Client.MCGroupExtensions
{
    public static class MCGroupDtoPartialExtensions
    {
        public static Partial<MCGroupDto> WithElements(this Partial<MCGroupDto> it)
            => it.AddFieldName("elements");
        
        public static Partial<MCGroupDto> WithElements(this Partial<MCGroupDto> it, Func<Partial<MCElementDto>, Partial<MCElementDto>> partialBuilder)
            => it.AddFieldName("elements", partialBuilder(new Partial<MCElementDto>()));
        
    }
    
}
