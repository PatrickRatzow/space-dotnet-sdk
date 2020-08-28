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
    public sealed class NonWorkingDaysEvent
         : IPropagatePropertyAccessPath
    {
        public NonWorkingDaysEvent() { }
        
        public NonWorkingDaysEvent(TDMemberProfile profile, List<NonWorkingDays> days)
        {
            Profile = profile;
            Days = days;
        }
        
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(NonWorkingDaysEvent), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<List<NonWorkingDays>> _days = new PropertyValue<List<NonWorkingDays>>(nameof(NonWorkingDaysEvent), nameof(Days));
        
        [Required]
        [JsonPropertyName("days")]
        public List<NonWorkingDays> Days
        {
            get { return _days.GetValue(); }
            set { _days.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _days.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
