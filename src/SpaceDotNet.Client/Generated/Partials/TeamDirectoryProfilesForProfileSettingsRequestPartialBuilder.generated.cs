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

namespace SpaceDotNet.Client.TeamDirectoryProfilesForProfileSettingsRequestPartialBuilder
{
    public static class TeamDirectoryProfilesForProfileSettingsRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithThemeName(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("themeName");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithFirstDayOfWeek(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("firstDayOfWeek");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithFirstDayOfWeek(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it, Func<Partial<Weekday>, Partial<Weekday>> partialBuilder)
            => it.AddFieldName("firstDayOfWeek", partialBuilder(new Partial<Weekday>(it)));
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithDraftType(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("draftType");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithDraftType(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("draftType", partialBuilder(new Partial<DraftDocumentType>(it)));
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithTodoFilters(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("todoFilters");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithCalendarView(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("calendarView");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithEmailNotificationsEnabled(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("emailNotificationsEnabled");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsRequest> WithNotificationEmail(this Partial<TeamDirectoryProfilesForProfileSettingsRequest> it)
            => it.AddFieldName("notificationEmail");
        
    }
    
}