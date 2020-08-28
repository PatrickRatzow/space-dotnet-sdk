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

namespace SpaceDotNet.Client.ChannelItemRecordPartialBuilder
{
    public static class ChannelItemRecordPartialExtensions
    {
        public static Partial<ChannelItemRecord> WithText(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("text");
        
        public static Partial<ChannelItemRecord> WithDetails(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("details");
        
        public static Partial<ChannelItemRecord> WithDetails(this Partial<ChannelItemRecord> it, Func<Partial<M2ItemContentDetails>, Partial<M2ItemContentDetails>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<M2ItemContentDetails>(it)));
        
        public static Partial<ChannelItemRecord> WithAuthor(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("author");
        
        public static Partial<ChannelItemRecord> WithAuthor(this Partial<ChannelItemRecord> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<ChannelItemRecord> WithCreated(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("created");
        
        public static Partial<ChannelItemRecord> WithTime(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("time");
        
        public static Partial<ChannelItemRecord> WithReactions(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("reactions");
        
        public static Partial<ChannelItemRecord> WithReactions(this Partial<ChannelItemRecord> it, Func<Partial<AllReactionsToItemRecord>, Partial<AllReactionsToItemRecord>> partialBuilder)
            => it.AddFieldName("reactions", partialBuilder(new Partial<AllReactionsToItemRecord>(it)));
        
        public static Partial<ChannelItemRecord> WithThread(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("thread");
        
        public static Partial<ChannelItemRecord> WithThread(this Partial<ChannelItemRecord> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("thread", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
        public static Partial<ChannelItemRecord> WithProjectedItem(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("projectedItem");
        
        public static Partial<ChannelItemRecord> WithProjectedItemRecursive(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("projectedItem!");
        
        public static Partial<ChannelItemRecord> WithProjectedItem(this Partial<ChannelItemRecord> it, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>> partialBuilder)
            => it.AddFieldName("projectedItem", partialBuilder(new Partial<ChannelItemRecord>(it)));
        
        public static Partial<ChannelItemRecord> WithAttachments(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("attachments");
        
        public static Partial<ChannelItemRecord> WithAttachments(this Partial<ChannelItemRecord> it, Func<Partial<AttachmentInfo>, Partial<AttachmentInfo>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentInfo>(it)));
        
        public static Partial<ChannelItemRecord> WithAttachmentsInfos(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("attachmentsInfos");
        
        public static Partial<ChannelItemRecord> WithAttachmentsInfos(this Partial<ChannelItemRecord> it, Func<Partial<AttachmentInfo>, Partial<AttachmentInfo>> partialBuilder)
            => it.AddFieldName("attachmentsInfos", partialBuilder(new Partial<AttachmentInfo>(it)));
        
        public static Partial<ChannelItemRecord> WithIsPending(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("pending");
        
        public static Partial<ChannelItemRecord> WithId(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<ChannelItemRecord> WithIsArchived(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<ChannelItemRecord> WithEdited(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("edited");
        
        public static Partial<ChannelItemRecord> WithIsPinned(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("pinned");
        
        public static Partial<ChannelItemRecord> WithSuggestedParticipants(this Partial<ChannelItemRecord> it)
            => it.AddFieldName("suggestedParticipants");
        
        public static Partial<ChannelItemRecord> WithSuggestedParticipants(this Partial<ChannelItemRecord> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("suggestedParticipants", partialBuilder(new Partial<CPrincipal>(it)));
        
    }
    
}
