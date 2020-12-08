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

namespace JetBrains.Space.Client.ESHubProfileLoginDetailsPartialBuilder
{
    public static class ESHubProfileLoginDetailsPartialExtensions
    {
        public static Partial<ESHubProfileLoginDetails> WithLogin(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("login");
        
        public static Partial<ESHubProfileLoginDetails> WithHubAuthModuleLogin(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("hubAuthModuleLogin");
        
        public static Partial<ESHubProfileLoginDetails> WithFirstName(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("firstName");
        
        public static Partial<ESHubProfileLoginDetails> WithLastName(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("lastName");
        
        public static Partial<ESHubProfileLoginDetails> WithEmail(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("email");
        
        public static Partial<ESHubProfileLoginDetails> WithIsEmailVerified(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("emailVerified");
        
        public static Partial<ESHubProfileLoginDetails> WithAvatarUrl(this Partial<ESHubProfileLoginDetails> it)
            => it.AddFieldName("avatarUrl");
        
    }
    
}
