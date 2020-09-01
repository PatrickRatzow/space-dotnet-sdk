// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.TDMemberInLocationMapPartialBuilder
{
    public static class TDMemberInLocationMapPartialExtensions
    {
        public static Partial<TDMemberInLocationMap> WithProfile(this Partial<TDMemberInLocationMap> it)
            => it.AddFieldName("profile");
        
        public static Partial<TDMemberInLocationMap> WithProfile(this Partial<TDMemberInLocationMap> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<TDMemberInLocationMap> WithMemberLocation(this Partial<TDMemberInLocationMap> it)
            => it.AddFieldName("memberLocation");
        
        public static Partial<TDMemberInLocationMap> WithMemberLocation(this Partial<TDMemberInLocationMap> it, Func<Partial<TDMemberLocation>, Partial<TDMemberLocation>> partialBuilder)
            => it.AddFieldName("memberLocation", partialBuilder(new Partial<TDMemberLocation>(it)));
        
        public static Partial<TDMemberInLocationMap> WithLocationMapPoint(this Partial<TDMemberInLocationMap> it)
            => it.AddFieldName("locationMapPoint");
        
        public static Partial<TDMemberInLocationMap> WithLocationMapPoint(this Partial<TDMemberInLocationMap> it, Func<Partial<TDLocationMapPoint>, Partial<TDLocationMapPoint>> partialBuilder)
            => it.AddFieldName("locationMapPoint", partialBuilder(new Partial<TDLocationMapPoint>(it)));
        
    }
    
}