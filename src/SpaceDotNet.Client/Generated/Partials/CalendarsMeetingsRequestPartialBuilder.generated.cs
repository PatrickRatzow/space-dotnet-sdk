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

namespace SpaceDotNet.Client.CalendarsMeetingsRequestPartialBuilder
{
    public static class CalendarsMeetingsRequestPartialExtensions
    {
        public static Partial<CalendarsMeetingsRequest> WithSummary(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("summary");
        
        public static Partial<CalendarsMeetingsRequest> WithDescription(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<CalendarsMeetingsRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("occurrenceRule");
        
        public static Partial<CalendarsMeetingsRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsRequest> it, Func<Partial<CalendarEventSpecDto>, Partial<CalendarEventSpecDto>> partialBuilder)
            => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpecDto>(it)));
        
        public static Partial<CalendarsMeetingsRequest> WithLocations(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("locations");
        
        public static Partial<CalendarsMeetingsRequest> WithProfiles(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("profiles");
        
        public static Partial<CalendarsMeetingsRequest> WithExternalParticipants(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("externalParticipants");
        
        public static Partial<CalendarsMeetingsRequest> WithTeams(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("teams");
        
        public static Partial<CalendarsMeetingsRequest> WithVisibility(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("visibility");
        
        public static Partial<CalendarsMeetingsRequest> WithVisibility(this Partial<CalendarsMeetingsRequest> it, Func<Partial<MeetingVisibility>, Partial<MeetingVisibility>> partialBuilder)
            => it.AddFieldName("visibility", partialBuilder(new Partial<MeetingVisibility>(it)));
        
        public static Partial<CalendarsMeetingsRequest> WithModificationPreference(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("modificationPreference");
        
        public static Partial<CalendarsMeetingsRequest> WithModificationPreference(this Partial<CalendarsMeetingsRequest> it, Func<Partial<MeetingModificationPreference>, Partial<MeetingModificationPreference>> partialBuilder)
            => it.AddFieldName("modificationPreference", partialBuilder(new Partial<MeetingModificationPreference>(it)));
        
        public static Partial<CalendarsMeetingsRequest> WithJoiningPreference(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("joiningPreference");
        
        public static Partial<CalendarsMeetingsRequest> WithJoiningPreference(this Partial<CalendarsMeetingsRequest> it, Func<Partial<MeetingJoiningPreference>, Partial<MeetingJoiningPreference>> partialBuilder)
            => it.AddFieldName("joiningPreference", partialBuilder(new Partial<MeetingJoiningPreference>(it)));
        
        public static Partial<CalendarsMeetingsRequest> WithNotifyOnExport(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("notifyOnExport");
        
        public static Partial<CalendarsMeetingsRequest> WithOrganizer(this Partial<CalendarsMeetingsRequest> it)
            => it.AddFieldName("organizer");
        
    }
    
}