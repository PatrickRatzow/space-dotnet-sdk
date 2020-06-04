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

namespace SpaceDotNet.Client.UpdateInvitationRequestExtensions
{
    public static class UpdateInvitationRequestPartialExtensions
    {
        public static Partial<UpdateInvitationRequest> WithInviteeEmail(this Partial<UpdateInvitationRequest> it)    => it.AddFieldName("inviteeEmail");
        
        public static Partial<UpdateInvitationRequest> WithInviteeFirstName(this Partial<UpdateInvitationRequest> it)    => it.AddFieldName("inviteeFirstName");
        
        public static Partial<UpdateInvitationRequest> WithInviteeLastName(this Partial<UpdateInvitationRequest> it)    => it.AddFieldName("inviteeLastName");
        
        public static Partial<UpdateInvitationRequest> WithTeam(this Partial<UpdateInvitationRequest> it)    => it.AddFieldName("team");
        
        public static Partial<UpdateInvitationRequest> WithTeam(this Partial<UpdateInvitationRequest> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)    => it.AddFieldName("team", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<UpdateInvitationRequest> WithRole(this Partial<UpdateInvitationRequest> it)    => it.AddFieldName("role");
        
        public static Partial<UpdateInvitationRequest> WithRole(this Partial<UpdateInvitationRequest> it, Func<Partial<TDRoleDto>, Partial<TDRoleDto>> partialBuilder)    => it.AddFieldName("role", partialBuilder(new Partial<TDRoleDto>()));
        
    }
    
}