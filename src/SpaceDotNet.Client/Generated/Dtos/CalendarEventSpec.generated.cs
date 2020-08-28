// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class CalendarEventSpec
         : IPropagatePropertyAccessPath
    {
        public CalendarEventSpec() { }
        
        public CalendarEventSpec(SpaceTime start, SpaceTime end, bool allDay, ATimeZone timezone, RecurrenceRule? recurrenceRule = null, string? parentId = null, SpaceTime? initialMeetingStart = null, BusyStatus? busyStatus = null)
        {
            Start = start;
            End = end;
            RecurrenceRule = recurrenceRule;
            IsAllDay = allDay;
            Timezone = timezone;
            ParentId = parentId;
            InitialMeetingStart = initialMeetingStart;
            BusyStatus = busyStatus;
        }
        
        private PropertyValue<SpaceTime> _start = new PropertyValue<SpaceTime>(nameof(CalendarEventSpec), nameof(Start));
        
        [Required]
        [JsonPropertyName("start")]
        public SpaceTime Start
        {
            get { return _start.GetValue(); }
            set { _start.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _end = new PropertyValue<SpaceTime>(nameof(CalendarEventSpec), nameof(End));
        
        [Required]
        [JsonPropertyName("end")]
        public SpaceTime End
        {
            get { return _end.GetValue(); }
            set { _end.SetValue(value); }
        }
    
        private PropertyValue<RecurrenceRule?> _recurrenceRule = new PropertyValue<RecurrenceRule?>(nameof(CalendarEventSpec), nameof(RecurrenceRule));
        
        [JsonPropertyName("recurrenceRule")]
        public RecurrenceRule? RecurrenceRule
        {
            get { return _recurrenceRule.GetValue(); }
            set { _recurrenceRule.SetValue(value); }
        }
    
        private PropertyValue<bool> _allDay = new PropertyValue<bool>(nameof(CalendarEventSpec), nameof(IsAllDay));
        
        [Required]
        [JsonPropertyName("allDay")]
        public bool IsAllDay
        {
            get { return _allDay.GetValue(); }
            set { _allDay.SetValue(value); }
        }
    
        private PropertyValue<ATimeZone> _timezone = new PropertyValue<ATimeZone>(nameof(CalendarEventSpec), nameof(Timezone));
        
        [Required]
        [JsonPropertyName("timezone")]
        public ATimeZone Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(CalendarEventSpec), nameof(ParentId));
        
        [JsonPropertyName("parentId")]
        public string? ParentId
        {
            get { return _parentId.GetValue(); }
            set { _parentId.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _initialMeetingStart = new PropertyValue<SpaceTime?>(nameof(CalendarEventSpec), nameof(InitialMeetingStart));
        
        [JsonPropertyName("initialMeetingStart")]
        public SpaceTime? InitialMeetingStart
        {
            get { return _initialMeetingStart.GetValue(); }
            set { _initialMeetingStart.SetValue(value); }
        }
    
        private PropertyValue<BusyStatus?> _busyStatus = new PropertyValue<BusyStatus?>(nameof(CalendarEventSpec), nameof(BusyStatus));
        
        [JsonPropertyName("busyStatus")]
        public BusyStatus? BusyStatus
        {
            get { return _busyStatus.GetValue(); }
            set { _busyStatus.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _start.SetAccessPath(path, validateHasBeenSet);
            _end.SetAccessPath(path, validateHasBeenSet);
            _recurrenceRule.SetAccessPath(path, validateHasBeenSet);
            _allDay.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _parentId.SetAccessPath(path, validateHasBeenSet);
            _initialMeetingStart.SetAccessPath(path, validateHasBeenSet);
            _busyStatus.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
