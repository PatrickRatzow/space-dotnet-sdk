// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5118074+00:00
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

namespace SpaceDotNet.Client.PollRecordExtensions
{
    public static class PollRecordDtoPartialExtensions
    {
        public static Partial<PollRecordDto> WithId(this Partial<PollRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<PollRecordDto> WithOwner(this Partial<PollRecordDto> it)
            => it.AddFieldName("owner");
        
        public static Partial<PollRecordDto> WithOwner(this Partial<PollRecordDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<PollRecordDto> WithQuestion(this Partial<PollRecordDto> it)
            => it.AddFieldName("question");
        
        public static Partial<PollRecordDto> WithMeVote(this Partial<PollRecordDto> it)
            => it.AddFieldName("meVote");
        
        public static Partial<PollRecordDto> WithCountPeople(this Partial<PollRecordDto> it)
            => it.AddFieldName("countPeople");
        
        public static Partial<PollRecordDto> WithAnonymous(this Partial<PollRecordDto> it)
            => it.AddFieldName("anonymous");
        
        public static Partial<PollRecordDto> WithClosed(this Partial<PollRecordDto> it)
            => it.AddFieldName("closed");
        
        public static Partial<PollRecordDto> WithExtendable(this Partial<PollRecordDto> it)
            => it.AddFieldName("extendable");
        
        public static Partial<PollRecordDto> WithMultiChoice(this Partial<PollRecordDto> it)
            => it.AddFieldName("multiChoice");
        
        public static Partial<PollRecordDto> WithEnded(this Partial<PollRecordDto> it)
            => it.AddFieldName("ended");
        
        public static Partial<PollRecordDto> WithExpirationTime(this Partial<PollRecordDto> it)
            => it.AddFieldName("expirationTime");
        
        public static Partial<PollRecordDto> WithVotes(this Partial<PollRecordDto> it)
            => it.AddFieldName("votes");
        
        public static Partial<PollRecordDto> WithVotes(this Partial<PollRecordDto> it, Func<Partial<VoteGroupDto>, Partial<VoteGroupDto>> partialBuilder)
            => it.AddFieldName("votes", partialBuilder(new Partial<VoteGroupDto>()));
        
    }
    
}
