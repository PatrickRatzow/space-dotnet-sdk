// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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

namespace SpaceDotNet.Client.CodeReviewRecordDtoPartialBuilder
{
    public static class CodeReviewRecordDtoPartialExtensions
    {
        public static Partial<CodeReviewRecordDto> WithId(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<CodeReviewRecordDto> WithCounter(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("counter");
        
        public static Partial<CodeReviewRecordDto> WithCounter(this Partial<CodeReviewRecordDto> it, Func<Partial<CounterDto>, Partial<CounterDto>> partialBuilder)
            => it.AddFieldName("counter", partialBuilder(new Partial<CounterDto>(it)));
        
        public static Partial<CodeReviewRecordDto> WithProjectId(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("projectId");
        
        public static Partial<CodeReviewRecordDto> WithAuthors(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("authors");
        
        public static Partial<CodeReviewRecordDto> WithAuthors(this Partial<CodeReviewRecordDto> it, Func<Partial<CodeReviewParticipantRecordDto>, Partial<CodeReviewParticipantRecordDto>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<CodeReviewParticipantRecordDto>(it)));
        
        public static Partial<CodeReviewRecordDto> WithParticipants(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("participants");
        
        public static Partial<CodeReviewRecordDto> WithParticipants(this Partial<CodeReviewRecordDto> it, Func<Partial<CodeReviewParticipantDto>, Partial<CodeReviewParticipantDto>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipantDto>(it)));
        
        public static Partial<CodeReviewRecordDto> WithReviewers(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("reviewers");
        
        public static Partial<CodeReviewRecordDto> WithReviewers(this Partial<CodeReviewRecordDto> it, Func<Partial<CodeReviewParticipantRecordDto>, Partial<CodeReviewParticipantRecordDto>> partialBuilder)
            => it.AddFieldName("reviewers", partialBuilder(new Partial<CodeReviewParticipantRecordDto>(it)));
        
        public static Partial<CodeReviewRecordDto> WithWatchers(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("watchers");
        
        public static Partial<CodeReviewRecordDto> WithWatchers(this Partial<CodeReviewRecordDto> it, Func<Partial<CodeReviewParticipantRecordDto>, Partial<CodeReviewParticipantRecordDto>> partialBuilder)
            => it.AddFieldName("watchers", partialBuilder(new Partial<CodeReviewParticipantRecordDto>(it)));
        
        public static Partial<CodeReviewRecordDto> WithCount(this Partial<CodeReviewRecordDto> it)
            => it.AddFieldName("count");
        
    }
    
}