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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ProfileMembershipRecordPartialBuilder
{
    public static class ProfileMembershipRecordPartialExtensions
    {
        public static Partial<ProfileMembershipRecord> WithId(this Partial<ProfileMembershipRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<ProfileMembershipRecord> WithMemberships(this Partial<ProfileMembershipRecord> it)
            => it.AddFieldName("memberships");
        
        public static Partial<ProfileMembershipRecord> WithMemberships(this Partial<ProfileMembershipRecord> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("memberships", partialBuilder(new Partial<TDMembership>(it)));
        
        public static Partial<ProfileMembershipRecord> WithUnapprovedMemberships(this Partial<ProfileMembershipRecord> it)
            => it.AddFieldName("unapprovedMemberships");
        
        public static Partial<ProfileMembershipRecord> WithUnapprovedMemberships(this Partial<ProfileMembershipRecord> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("unapprovedMemberships", partialBuilder(new Partial<TDMembership>(it)));
        
    }
    
}
