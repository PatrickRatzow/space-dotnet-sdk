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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.AuthModulesTestLdapPostRequestPartialBuilder
{
    public static class AuthModulesTestLdapPostRequestPartialExtensions
    {
        public static Partial<AuthModulesTestLdapPostRequest> WithSettings(this Partial<AuthModulesTestLdapPostRequest> it)
            => it.AddFieldName("settings");
        
        public static Partial<AuthModulesTestLdapPostRequest> WithSettings(this Partial<AuthModulesTestLdapPostRequest> it, Func<Partial<ESLdapAuthModuleSettings>, Partial<ESLdapAuthModuleSettings>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESLdapAuthModuleSettings>(it)));
        
        public static Partial<AuthModulesTestLdapPostRequest> WithUsername(this Partial<AuthModulesTestLdapPostRequest> it)
            => it.AddFieldName("username");
        
        public static Partial<AuthModulesTestLdapPostRequest> WithPassword(this Partial<AuthModulesTestLdapPostRequest> it)
            => it.AddFieldName("password");
        
    }
    
}