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

namespace SpaceDotNet.Client.EmojiReactionRecordPartialBuilder
{
    public static class EmojiReactionRecordPartialExtensions
    {
        public static Partial<EmojiReactionRecord> WithId(this Partial<EmojiReactionRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<EmojiReactionRecord> WithItemId(this Partial<EmojiReactionRecord> it)
            => it.AddFieldName("itemId");
        
        public static Partial<EmojiReactionRecord> WithEmoji(this Partial<EmojiReactionRecord> it)
            => it.AddFieldName("emoji");
        
        public static Partial<EmojiReactionRecord> WithCount(this Partial<EmojiReactionRecord> it)
            => it.AddFieldName("count");
        
        public static Partial<EmojiReactionRecord> WithIsMeReacted(this Partial<EmojiReactionRecord> it)
            => it.AddFieldName("meReacted");
        
        public static Partial<EmojiReactionRecord> WithOrder(this Partial<EmojiReactionRecord> it)
            => it.AddFieldName("order");
        
    }
    
}