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

namespace JetBrains.Space.Client.M2ChannelContentCodeReviewDiscussionPartialBuilder
{
    public static class M2ChannelContentCodeReviewDiscussionPartialExtensions
    {
        public static Partial<M2ChannelContentCodeReviewDiscussion> WithCodeReviewDiscussion(this Partial<M2ChannelContentCodeReviewDiscussion> it)
            => it.AddFieldName("codeReviewDiscussion");
        
        public static Partial<M2ChannelContentCodeReviewDiscussion> WithNotificationDefaults(this Partial<M2ChannelContentCodeReviewDiscussion> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentCodeReviewDiscussion> WithNotificationDefaults(this Partial<M2ChannelContentCodeReviewDiscussion> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
    }
    
}
