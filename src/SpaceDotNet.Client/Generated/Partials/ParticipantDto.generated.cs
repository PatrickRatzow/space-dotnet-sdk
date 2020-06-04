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

namespace SpaceDotNet.Client.ParticipantExtensions
{
    public static class ParticipantDtoPartialExtensions
    {
        public static Partial<ParticipantDto> WithUser(this Partial<ParticipantDto> it)
            => it.AddFieldName("user");
        
        public static Partial<ParticipantDto> WithUser(this Partial<ParticipantDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("user", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<ParticipantDto> WithStatus(this Partial<ParticipantDto> it)
            => it.AddFieldName("status");
        
        public static Partial<ParticipantDto> WithStatus(this Partial<ParticipantDto> it, Func<Partial<EventParticipationStatus>, Partial<EventParticipationStatus>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<EventParticipationStatus>()));
        
    }
    
}
