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

namespace JetBrains.Space.Client.ReactionTypeRecordPartialBuilder
{
    public static class ReactionTypeRecordPartialExtensions
    {
        public static Partial<ReactionTypeRecord> WithId(this Partial<ReactionTypeRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<ReactionTypeRecord> WithIsArchived(this Partial<ReactionTypeRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<ReactionTypeRecord> WithData(this Partial<ReactionTypeRecord> it)
            => it.AddFieldName("data");
        
        public static Partial<ReactionTypeRecord> WithData(this Partial<ReactionTypeRecord> it, Func<Partial<ReactionData>, Partial<ReactionData>> partialBuilder)
            => it.AddFieldName("data", partialBuilder(new Partial<ReactionData>(it)));
        
        public static Partial<ReactionTypeRecord> WithProvider(this Partial<ReactionTypeRecord> it)
            => it.AddFieldName("provider");
        
        public static Partial<ReactionTypeRecord> WithProvider(this Partial<ReactionTypeRecord> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("provider", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<ReactionTypeRecord> WithAddedAt(this Partial<ReactionTypeRecord> it)
            => it.AddFieldName("addedAt");
        
        public static Partial<ReactionTypeRecord> WithOrder(this Partial<ReactionTypeRecord> it)
            => it.AddFieldName("order");
        
    }
    
}
