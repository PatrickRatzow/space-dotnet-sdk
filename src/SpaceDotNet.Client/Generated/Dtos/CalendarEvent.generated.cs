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
    public sealed class CalendarEvent
         : IPropagatePropertyAccessPath
    {
        public CalendarEvent() { }
        
        public CalendarEvent(bool? calendarEvent = null, SpaceTime? starts = null, SpaceTime? ends = null, ATimeZone? timezone = null, List<TDLocation>? rooms = null, bool? allDay = null)
        {
            IsCalendarEvent = calendarEvent;
            Starts = starts;
            Ends = ends;
            Timezone = timezone;
            Rooms = rooms;
            IsAllDay = allDay;
        }
        
        private PropertyValue<bool?> _calendarEvent = new PropertyValue<bool?>(nameof(CalendarEvent), nameof(IsCalendarEvent));
        
        [JsonPropertyName("calendarEvent")]
        public bool? IsCalendarEvent
        {
            get { return _calendarEvent.GetValue(); }
            set { _calendarEvent.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _starts = new PropertyValue<SpaceTime?>(nameof(CalendarEvent), nameof(Starts));
        
        [JsonPropertyName("starts")]
        public SpaceTime? Starts
        {
            get { return _starts.GetValue(); }
            set { _starts.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _ends = new PropertyValue<SpaceTime?>(nameof(CalendarEvent), nameof(Ends));
        
        [JsonPropertyName("ends")]
        public SpaceTime? Ends
        {
            get { return _ends.GetValue(); }
            set { _ends.SetValue(value); }
        }
    
        private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(CalendarEvent), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZone? Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocation>?> _rooms = new PropertyValue<List<TDLocation>?>(nameof(CalendarEvent), nameof(Rooms));
        
        [JsonPropertyName("rooms")]
        public List<TDLocation>? Rooms
        {
            get { return _rooms.GetValue(); }
            set { _rooms.SetValue(value); }
        }
    
        private PropertyValue<bool?> _allDay = new PropertyValue<bool?>(nameof(CalendarEvent), nameof(IsAllDay));
        
        [JsonPropertyName("allDay")]
        public bool? IsAllDay
        {
            get { return _allDay.GetValue(); }
            set { _allDay.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _calendarEvent.SetAccessPath(path, validateHasBeenSet);
            _starts.SetAccessPath(path, validateHasBeenSet);
            _ends.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _rooms.SetAccessPath(path, validateHasBeenSet);
            _allDay.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
