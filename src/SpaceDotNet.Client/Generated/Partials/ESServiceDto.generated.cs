// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4670277+00:00
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

namespace SpaceDotNet.Client.ESServiceExtensions
{
    public static class ESServiceDtoPartialExtensions
    {
        public static Partial<ESServiceDto> WithId(this Partial<ESServiceDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ESServiceDto> WithOwner(this Partial<ESServiceDto> it)
            => it.AddFieldName("owner");
        
        public static Partial<ESServiceDto> WithOwner(this Partial<ESServiceDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<ESServiceDto> WithType(this Partial<ESServiceDto> it)
            => it.AddFieldName("type");
        
        public static Partial<ESServiceDto> WithClientId(this Partial<ESServiceDto> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ESServiceDto> WithName(this Partial<ESServiceDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ESServiceDto> WithRedirectURIs(this Partial<ESServiceDto> it)
            => it.AddFieldName("redirectURIs");
        
        public static Partial<ESServiceDto> WithArchived(this Partial<ESServiceDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<ESServiceDto> WithLastClientCredentialsAccess(this Partial<ESServiceDto> it)
            => it.AddFieldName("lastClientCredentialsAccess");
        
        public static Partial<ESServiceDto> WithLastClientCredentialsAccess(this Partial<ESServiceDto> it, Func<Partial<AccessRecordDto>, Partial<AccessRecordDto>> partialBuilder)
            => it.AddFieldName("lastClientCredentialsAccess", partialBuilder(new Partial<AccessRecordDto>()));
        
    }
    
}
