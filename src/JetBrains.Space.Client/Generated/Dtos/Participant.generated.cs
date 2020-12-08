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
    public sealed class Participant
         : IPropagatePropertyAccessPath
    {
        public Participant() { }
        
        public Participant(TDMemberProfile user, EventParticipationStatus status)
        {
            User = user;
            Status = status;
        }
        
        private PropertyValue<TDMemberProfile> _user = new PropertyValue<TDMemberProfile>(nameof(Participant), nameof(User));
        
        [Required]
        [JsonPropertyName("user")]
        public TDMemberProfile User
        {
            get => _user.GetValue();
            set => _user.SetValue(value);
        }
    
        private PropertyValue<EventParticipationStatus> _status = new PropertyValue<EventParticipationStatus>(nameof(Participant), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public EventParticipationStatus Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _user.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
