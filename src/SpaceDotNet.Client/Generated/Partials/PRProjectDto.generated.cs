// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5079976+00:00
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

namespace SpaceDotNet.Client.PRProjectExtensions
{
    public static class PRProjectDtoPartialExtensions
    {
        public static Partial<PRProjectDto> WithId(this Partial<PRProjectDto> it)
            => it.AddFieldName("id");
        
        public static Partial<PRProjectDto> WithKey(this Partial<PRProjectDto> it)
            => it.AddFieldName("key");
        
        public static Partial<PRProjectDto> WithKey(this Partial<PRProjectDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("key", partialBuilder(new Partial<ProjectKeyDto>()));
        
        public static Partial<PRProjectDto> WithName(this Partial<PRProjectDto> it)
            => it.AddFieldName("name");
        
        public static Partial<PRProjectDto> WithPrivate(this Partial<PRProjectDto> it)
            => it.AddFieldName("private");
        
        public static Partial<PRProjectDto> WithDescription(this Partial<PRProjectDto> it)
            => it.AddFieldName("description");
        
        public static Partial<PRProjectDto> WithIcon(this Partial<PRProjectDto> it)
            => it.AddFieldName("icon");
        
        public static Partial<PRProjectDto> WithLatestRepositoryActivity(this Partial<PRProjectDto> it)
            => it.AddFieldName("latestRepositoryActivity");
        
        public static Partial<PRProjectDto> WithArchived(this Partial<PRProjectDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<PRProjectDto> WithAdminProfiles(this Partial<PRProjectDto> it)
            => it.AddFieldName("adminProfiles");
        
        public static Partial<PRProjectDto> WithAdminProfiles(this Partial<PRProjectDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("adminProfiles", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<PRProjectDto> WithAdminTeams(this Partial<PRProjectDto> it)
            => it.AddFieldName("adminTeams");
        
        public static Partial<PRProjectDto> WithAdminTeams(this Partial<PRProjectDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("adminTeams", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<PRProjectDto> WithMemberProfiles(this Partial<PRProjectDto> it)
            => it.AddFieldName("memberProfiles");
        
        public static Partial<PRProjectDto> WithMemberProfiles(this Partial<PRProjectDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("memberProfiles", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<PRProjectDto> WithMemberTeams(this Partial<PRProjectDto> it)
            => it.AddFieldName("memberTeams");
        
        public static Partial<PRProjectDto> WithMemberTeams(this Partial<PRProjectDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("memberTeams", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<PRProjectDto> WithRepos(this Partial<PRProjectDto> it)
            => it.AddFieldName("repos");
        
        public static Partial<PRProjectDto> WithRepos(this Partial<PRProjectDto> it, Func<Partial<PRRepositoryInfoDto>, Partial<PRRepositoryInfoDto>> partialBuilder)
            => it.AddFieldName("repos", partialBuilder(new Partial<PRRepositoryInfoDto>()));
        
        public static Partial<PRProjectDto> WithTags(this Partial<PRProjectDto> it)
            => it.AddFieldName("tags");
        
        public static Partial<PRProjectDto> WithTags(this Partial<PRProjectDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("tags", partialBuilder(new Partial<string>()));
        
    }
    
}
