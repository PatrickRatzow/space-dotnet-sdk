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

namespace JetBrains.Space.Client.M2ChannelContactPartialBuilder
{
    public static class M2ChannelContactPartialExtensions
    {
        public static Partial<M2ChannelContact> WithDefaultName(this Partial<M2ChannelContact> it)
            => it.AddFieldName("defaultName");
        
        public static Partial<M2ChannelContact> WithKey(this Partial<M2ChannelContact> it)
            => it.AddFieldName("key");
        
        public static Partial<M2ChannelContact> WithExt(this Partial<M2ChannelContact> it)
            => it.AddFieldName("ext");
        
        public static Partial<M2ChannelContact> WithExt(this Partial<M2ChannelContact> it, Func<Partial<M2ChannelContactInfo>, Partial<M2ChannelContactInfo>> partialBuilder)
            => it.AddFieldName("ext", partialBuilder(new Partial<M2ChannelContactInfo>(it)));
        
    }
    
}
