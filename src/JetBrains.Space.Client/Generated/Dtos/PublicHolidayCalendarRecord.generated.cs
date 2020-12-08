// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class PublicHolidayCalendarRecord
         : IPropagatePropertyAccessPath
    {
        public PublicHolidayCalendarRecord() { }
        
        public PublicHolidayCalendarRecord(string id, bool archived, string name, int eventsCount, TDLocation location, DateTime? firstDate = null, DateTime? lastDate = null)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            FirstDate = firstDate;
            LastDate = lastDate;
            EventsCount = eventsCount;
            Location = location;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PublicHolidayCalendarRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PublicHolidayCalendarRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PublicHolidayCalendarRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _firstDate = new PropertyValue<DateTime?>(nameof(PublicHolidayCalendarRecord), nameof(FirstDate));
        
        [JsonPropertyName("firstDate")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? FirstDate
        {
            get => _firstDate.GetValue();
            set => _firstDate.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _lastDate = new PropertyValue<DateTime?>(nameof(PublicHolidayCalendarRecord), nameof(LastDate));
        
        [JsonPropertyName("lastDate")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? LastDate
        {
            get => _lastDate.GetValue();
            set => _lastDate.SetValue(value);
        }
    
        private PropertyValue<int> _eventsCount = new PropertyValue<int>(nameof(PublicHolidayCalendarRecord), nameof(EventsCount));
        
        [Required]
        [JsonPropertyName("eventsCount")]
        public int EventsCount
        {
            get => _eventsCount.GetValue();
            set => _eventsCount.SetValue(value);
        }
    
        private PropertyValue<TDLocation> _location = new PropertyValue<TDLocation>(nameof(PublicHolidayCalendarRecord), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public TDLocation Location
        {
            get => _location.GetValue();
            set => _location.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _firstDate.SetAccessPath(path, validateHasBeenSet);
            _lastDate.SetAccessPath(path, validateHasBeenSet);
            _eventsCount.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
