// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5290140+00:00
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

namespace SpaceDotNet.Client.TDMemberWithTeamExtensions
{
    public static class TDMemberWithTeamDtoPartialExtensions
    {
        public static Partial<TDMemberWithTeamDto> WithProfile(this Partial<TDMemberWithTeamDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<TDMemberWithTeamDto> WithProfile(this Partial<TDMemberWithTeamDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<TDMemberWithTeamDto> WithTeams(this Partial<TDMemberWithTeamDto> it)
            => it.AddFieldName("teams");
        
        public static Partial<TDMemberWithTeamDto> WithTeams(this Partial<TDMemberWithTeamDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeamDto>()));
        
    }
    
}
