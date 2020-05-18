// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5439429+00:00
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

namespace SpaceDotNet.Client.CreateMembershipRequestExtensions
{
    public static class CreateMembershipRequestDtoPartialExtensions
    {
        public static Partial<CreateMembershipRequestDto> WithMemberId(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("memberId");
        
        public static Partial<CreateMembershipRequestDto> WithTeamId(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("teamId");
        
        public static Partial<CreateMembershipRequestDto> WithRoleId(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("roleId");
        
        public static Partial<CreateMembershipRequestDto> WithLead(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("lead");
        
        public static Partial<CreateMembershipRequestDto> WithManagerId(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("managerId");
        
        public static Partial<CreateMembershipRequestDto> WithSince(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("since");
        
        public static Partial<CreateMembershipRequestDto> WithTill(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("till");
        
        public static Partial<CreateMembershipRequestDto> WithActiveSince(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("activeSince");
        
        public static Partial<CreateMembershipRequestDto> WithActiveTill(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("activeTill");
        
        public static Partial<CreateMembershipRequestDto> WithPreviousMembershipId(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("previousMembershipId");
        
        public static Partial<CreateMembershipRequestDto> WithRequiresApproval(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("requiresApproval");
        
        public static Partial<CreateMembershipRequestDto> WithCustomFieldValues(this Partial<CreateMembershipRequestDto> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<CreateMembershipRequestDto> WithCustomFieldValues(this Partial<CreateMembershipRequestDto> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValueDto>()));
        
    }
    
}
