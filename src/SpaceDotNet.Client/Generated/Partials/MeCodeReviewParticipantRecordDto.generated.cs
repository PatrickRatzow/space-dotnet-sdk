// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5034210+00:00
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

namespace SpaceDotNet.Client.MeCodeReviewParticipantRecordExtensions
{
    public static class MeCodeReviewParticipantRecordDtoPartialExtensions
    {
        public static Partial<MeCodeReviewParticipantRecordDto> WithId(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithRole(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("role");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithTheirTurn(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("theirTurn");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithReviewerState(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("reviewerState");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithReview(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("review");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithReview(this Partial<MeCodeReviewParticipantRecordDto> it, Func<Partial<CodeReviewRecordDto>, Partial<CodeReviewRecordDto>> partialBuilder)
            => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecordDto>()));
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithParticipants(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("participants");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithParticipants(this Partial<MeCodeReviewParticipantRecordDto> it, Func<Partial<CodeReviewParticipantsDto>, Partial<CodeReviewParticipantsDto>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipantsDto>()));
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithPendingCounter(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("pendingCounter");
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithPendingCounter(this Partial<MeCodeReviewParticipantRecordDto> it, Func<Partial<CodeReviewPendingMessageCounterDto>, Partial<CodeReviewPendingMessageCounterDto>> partialBuilder)
            => it.AddFieldName("pendingCounter", partialBuilder(new Partial<CodeReviewPendingMessageCounterDto>()));
        
        public static Partial<MeCodeReviewParticipantRecordDto> WithArchived(this Partial<MeCodeReviewParticipantRecordDto> it)
            => it.AddFieldName("archived");
        
    }
    
}
