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
    public sealed class BirthdayEvent
         : IPropagatePropertyAccessPath
    {
        public BirthdayEvent() { }
        
        public BirthdayEvent(TDMemberWithTeam profile, DateTime birthday)
        {
            Profile = profile;
            Birthday = birthday;
        }
        
        private PropertyValue<TDMemberWithTeam> _profile = new PropertyValue<TDMemberWithTeam>(nameof(BirthdayEvent), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberWithTeam Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        private PropertyValue<DateTime> _birthday = new PropertyValue<DateTime>(nameof(BirthdayEvent), nameof(Birthday));
        
        [Required]
        [JsonPropertyName("birthday")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime Birthday
        {
            get => _birthday.GetValue();
            set => _birthday.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _birthday.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
