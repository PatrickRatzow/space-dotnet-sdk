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

namespace JetBrains.Space.Client.M2PrivateConversationChannelContentPartialBuilder
{
    public static class M2PrivateConversationChannelContentPartialExtensions
    {
        public static Partial<M2PrivateConversationChannelContent> WithChannelId(this Partial<M2PrivateConversationChannelContent> it)
            => it.AddFieldName("channelId");
        
        public static Partial<M2PrivateConversationChannelContent> WithSubject(this Partial<M2PrivateConversationChannelContent> it)
            => it.AddFieldName("subject");
        
        public static Partial<M2PrivateConversationChannelContent> WithMembers(this Partial<M2PrivateConversationChannelContent> it)
            => it.AddFieldName("members");
        
        public static Partial<M2PrivateConversationChannelContent> WithMembers(this Partial<M2PrivateConversationChannelContent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("members", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<M2PrivateConversationChannelContent> WithNotificationDefaults(this Partial<M2PrivateConversationChannelContent> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2PrivateConversationChannelContent> WithNotificationDefaults(this Partial<M2PrivateConversationChannelContent> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
    }
    
}
