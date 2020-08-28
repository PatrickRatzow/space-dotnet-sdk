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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.M2ChannelContentLocationPartialBuilder
{
    public static class M2ChannelContentLocationPartialExtensions
    {
        public static Partial<M2ChannelContentLocation> WithLocation(this Partial<M2ChannelContentLocation> it)
            => it.AddFieldName("location");
        
        public static Partial<M2ChannelContentLocation> WithLocation(this Partial<M2ChannelContentLocation> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<M2ChannelContentLocation> WithNotificationDefaults(this Partial<M2ChannelContentLocation> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentLocation> WithNotificationDefaults(this Partial<M2ChannelContentLocation> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
    }
    
}
