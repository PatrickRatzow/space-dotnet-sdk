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

namespace SpaceDotNet.Client.CodeReviewWithCountPartialBuilder
{
    public static class CodeReviewWithCountPartialExtensions
    {
        public static Partial<CodeReviewWithCount> WithReview(this Partial<CodeReviewWithCount> it)
            => it.AddFieldName("review");
        
        public static Partial<CodeReviewWithCount> WithReview(this Partial<CodeReviewWithCount> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
        public static Partial<CodeReviewWithCount> WithMessagesCount(this Partial<CodeReviewWithCount> it)
            => it.AddFieldName("messagesCount");
        
        public static Partial<CodeReviewWithCount> WithAuthors(this Partial<CodeReviewWithCount> it)
            => it.AddFieldName("authors");
        
        public static Partial<CodeReviewWithCount> WithAuthors(this Partial<CodeReviewWithCount> it, Func<Partial<GitCommitterProfile>, Partial<GitCommitterProfile>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<GitCommitterProfile>(it)));
        
        public static Partial<CodeReviewWithCount> WithParticipants(this Partial<CodeReviewWithCount> it)
            => it.AddFieldName("participants");
        
        public static Partial<CodeReviewWithCount> WithParticipants(this Partial<CodeReviewWithCount> it, Func<Partial<CodeReviewParticipants>, Partial<CodeReviewParticipants>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipants>(it)));
        
    }
    
}
