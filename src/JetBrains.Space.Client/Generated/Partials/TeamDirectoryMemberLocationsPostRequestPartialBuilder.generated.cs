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

namespace JetBrains.Space.Client.TeamDirectoryMemberLocationsPostRequestPartialBuilder
{
    public static class TeamDirectoryMemberLocationsPostRequestPartialExtensions
    {
        public static Partial<TeamDirectoryMemberLocationsPostRequest> WithMember(this Partial<TeamDirectoryMemberLocationsPostRequest> it)
            => it.AddFieldName("member");
        
        public static Partial<TeamDirectoryMemberLocationsPostRequest> WithMember(this Partial<TeamDirectoryMemberLocationsPostRequest> it, Func<Partial<ProfileIdentifier>, Partial<ProfileIdentifier>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<ProfileIdentifier>(it)));
        
        public static Partial<TeamDirectoryMemberLocationsPostRequest> WithLocation(this Partial<TeamDirectoryMemberLocationsPostRequest> it)
            => it.AddFieldName("location");
        
        public static Partial<TeamDirectoryMemberLocationsPostRequest> WithSince(this Partial<TeamDirectoryMemberLocationsPostRequest> it)
            => it.AddFieldName("since");
        
        public static Partial<TeamDirectoryMemberLocationsPostRequest> WithTill(this Partial<TeamDirectoryMemberLocationsPostRequest> it)
            => it.AddFieldName("till");
        
        public static Partial<TeamDirectoryMemberLocationsPostRequest> WithPreviousLocation(this Partial<TeamDirectoryMemberLocationsPostRequest> it)
            => it.AddFieldName("previousLocation");
        
    }
    
}
