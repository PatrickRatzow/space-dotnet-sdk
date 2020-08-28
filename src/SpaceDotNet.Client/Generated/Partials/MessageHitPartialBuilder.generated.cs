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

namespace SpaceDotNet.Client.MessageHitPartialBuilder
{
    public static class MessageHitPartialExtensions
    {
        public static Partial<MessageHit> WithId(this Partial<MessageHit> it)
            => it.AddFieldName("id");
        
        public static Partial<MessageHit> WithParentItemId(this Partial<MessageHit> it)
            => it.AddFieldName("parentItemId");
        
        public static Partial<MessageHit> WithScore(this Partial<MessageHit> it)
            => it.AddFieldName("score");
        
        public static Partial<MessageHit> WithChannel(this Partial<MessageHit> it)
            => it.AddFieldName("channel");
        
        public static Partial<MessageHit> WithChannel(this Partial<MessageHit> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
        public static Partial<MessageHit> WithRef(this Partial<MessageHit> it)
            => it.AddFieldName("ref");
        
        public static Partial<MessageHit> WithRef(this Partial<MessageHit> it, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>> partialBuilder)
            => it.AddFieldName("ref", partialBuilder(new Partial<ChannelItemRecord>(it)));
        
        public static Partial<MessageHit> WithMessage(this Partial<MessageHit> it)
            => it.AddFieldName("message");
        
        public static Partial<MessageHit> WithIsThreadStarter(this Partial<MessageHit> it)
            => it.AddFieldName("threadStarter");
        
        public static Partial<MessageHit> WithThread(this Partial<MessageHit> it)
            => it.AddFieldName("thread");
        
    }
    
}
