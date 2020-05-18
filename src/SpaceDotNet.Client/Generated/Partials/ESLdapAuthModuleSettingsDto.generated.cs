// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4626746+00:00
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

namespace SpaceDotNet.Client.ESLdapAuthModuleSettingsExtensions
{
    public static class ESLdapAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESLdapAuthModuleSettingsDto> WithType(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("type");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithServerUrl(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("serverUrl");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithConnectionTimeout(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("connectionTimeout");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithReadTimeout(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("readTimeout");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithSslKeystore(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("sslKeystore");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithSslKeystore(this Partial<ESLdapAuthModuleSettingsDto> it, Func<Partial<SSLKeystoreDto>, Partial<SSLKeystoreDto>> partialBuilder)
            => it.AddFieldName("sslKeystore", partialBuilder(new Partial<SSLKeystoreDto>()));
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithTeamMappings(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("teamMappings");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithTeamMappings(this Partial<ESLdapAuthModuleSettingsDto> it, Func<Partial<ESTeamMappingDto>, Partial<ESTeamMappingDto>> partialBuilder)
            => it.AddFieldName("teamMappings", partialBuilder(new Partial<ESTeamMappingDto>()));
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithReferralIgnored(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("referralIgnored");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithFilter(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("filter");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithBindUserDN(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("bindUserDN");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithBindUserPassword(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("bindUserPassword");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithAttributeNames(this Partial<ESLdapAuthModuleSettingsDto> it)
            => it.AddFieldName("attributeNames");
        
        public static Partial<ESLdapAuthModuleSettingsDto> WithAttributeNames(this Partial<ESLdapAuthModuleSettingsDto> it, Func<Partial<ESLdapAttributeNamesDto>, Partial<ESLdapAttributeNamesDto>> partialBuilder)
            => it.AddFieldName("attributeNames", partialBuilder(new Partial<ESLdapAttributeNamesDto>()));
        
    }
    
}
