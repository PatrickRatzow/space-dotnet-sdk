// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4470089+00:00
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.CodeReviewDiscussionRecordExtensions
{
    public static class CodeReviewDiscussionRecordDtoPartialExtensions
    {
        public static Partial<CodeReviewDiscussionRecordDto> WithId(this Partial<CodeReviewDiscussionRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<CodeReviewDiscussionRecordDto> WithReview(this Partial<CodeReviewDiscussionRecordDto> it)
            => it.AddFieldName("review");
        
        public static Partial<CodeReviewDiscussionRecordDto> WithReview(this Partial<CodeReviewDiscussionRecordDto> it, Func<Partial<CodeReviewRecordDto>, Partial<CodeReviewRecordDto>> partialBuilder)
            => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecordDto>()));
        
        public static Partial<CodeReviewDiscussionRecordDto> WithCreated(this Partial<CodeReviewDiscussionRecordDto> it)
            => it.AddFieldName("created");
        
        public static Partial<CodeReviewDiscussionRecordDto> WithChannel(this Partial<CodeReviewDiscussionRecordDto> it)
            => it.AddFieldName("channel");
        
        public static Partial<CodeReviewDiscussionRecordDto> WithChannel(this Partial<CodeReviewDiscussionRecordDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecordDto>()));
        
        public static Partial<CodeReviewDiscussionRecordDto> WithResolved(this Partial<CodeReviewDiscussionRecordDto> it)
            => it.AddFieldName("resolved");
        
    }
    
}
