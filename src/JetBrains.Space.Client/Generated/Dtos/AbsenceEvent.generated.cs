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
    public sealed class AbsenceEvent
         : IPropagatePropertyAccessPath
    {
        public AbsenceEvent() { }
        
        public AbsenceEvent(TDMemberWithTeam profile, List<AbsenceRecord> events)
        {
            Profile = profile;
            Events = events;
        }
        
        private PropertyValue<TDMemberWithTeam> _profile = new PropertyValue<TDMemberWithTeam>(nameof(AbsenceEvent), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberWithTeam Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        private PropertyValue<List<AbsenceRecord>> _events = new PropertyValue<List<AbsenceRecord>>(nameof(AbsenceEvent), nameof(Events));
        
        [Required]
        [JsonPropertyName("events")]
        public List<AbsenceRecord> Events
        {
            get => _events.GetValue();
            set => _events.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _events.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
