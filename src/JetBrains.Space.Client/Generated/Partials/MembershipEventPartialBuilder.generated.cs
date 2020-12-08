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

namespace JetBrains.Space.Client.MembershipEventPartialBuilder
{
    public static class MembershipEventPartialExtensions
    {
        public static Partial<MembershipEvent> WithProfile(this Partial<MembershipEvent> it)
            => it.AddFieldName("profile");
        
        public static Partial<MembershipEvent> WithProfile(this Partial<MembershipEvent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<MembershipEvent> WithMembership(this Partial<MembershipEvent> it)
            => it.AddFieldName("membership");
        
        public static Partial<MembershipEvent> WithMembership(this Partial<MembershipEvent> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("membership", partialBuilder(new Partial<TDMembership>(it)));
        
    }
    
}
