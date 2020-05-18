// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4661985+00:00
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

namespace SpaceDotNet.Client.ESRefreshTokenExtensions
{
    public static class ESRefreshTokenDtoPartialExtensions
    {
        public static Partial<ESRefreshTokenDto> WithId(this Partial<ESRefreshTokenDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ESRefreshTokenDto> WithScope(this Partial<ESRefreshTokenDto> it)
            => it.AddFieldName("scope");
        
        public static Partial<ESRefreshTokenDto> WithLastAccess(this Partial<ESRefreshTokenDto> it)
            => it.AddFieldName("lastAccess");
        
        public static Partial<ESRefreshTokenDto> WithLastAccess(this Partial<ESRefreshTokenDto> it, Func<Partial<AccessRecordDto>, Partial<AccessRecordDto>> partialBuilder)
            => it.AddFieldName("lastAccess", partialBuilder(new Partial<AccessRecordDto>()));
        
    }
    
}
