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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class CodeReviewParticipant
         : IPropagatePropertyAccessPath
    {
        public CodeReviewParticipant() { }
        
        public CodeReviewParticipant(TDMemberProfile user, CodeReviewParticipantRole role, ReviewerState? state = null, bool? theirTurn = null, List<CodeReviewParticipantQualityGateSlot>? qualityGateSlots = null, DateTime? addedAt = null)
        {
            User = user;
            Role = role;
            State = state;
            IsTheirTurn = theirTurn;
            QualityGateSlots = qualityGateSlots;
            AddedAt = addedAt;
        }
        
        private PropertyValue<TDMemberProfile> _user = new PropertyValue<TDMemberProfile>(nameof(CodeReviewParticipant), nameof(User));
        
        [Required]
        [JsonPropertyName("user")]
        public TDMemberProfile User
        {
            get => _user.GetValue();
            set => _user.SetValue(value);
        }
    
        private PropertyValue<CodeReviewParticipantRole> _role = new PropertyValue<CodeReviewParticipantRole>(nameof(CodeReviewParticipant), nameof(Role));
        
        [Required]
        [JsonPropertyName("role")]
        public CodeReviewParticipantRole Role
        {
            get => _role.GetValue();
            set => _role.SetValue(value);
        }
    
        private PropertyValue<ReviewerState?> _state = new PropertyValue<ReviewerState?>(nameof(CodeReviewParticipant), nameof(State));
        
        [JsonPropertyName("state")]
        public ReviewerState? State
        {
            get => _state.GetValue();
            set => _state.SetValue(value);
        }
    
        private PropertyValue<bool?> _theirTurn = new PropertyValue<bool?>(nameof(CodeReviewParticipant), nameof(IsTheirTurn));
        
        [JsonPropertyName("theirTurn")]
        public bool? IsTheirTurn
        {
            get => _theirTurn.GetValue();
            set => _theirTurn.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantQualityGateSlot>?> _qualityGateSlots = new PropertyValue<List<CodeReviewParticipantQualityGateSlot>?>(nameof(CodeReviewParticipant), nameof(QualityGateSlots));
        
        [JsonPropertyName("qualityGateSlots")]
        public List<CodeReviewParticipantQualityGateSlot>? QualityGateSlots
        {
            get => _qualityGateSlots.GetValue();
            set => _qualityGateSlots.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _addedAt = new PropertyValue<DateTime?>(nameof(CodeReviewParticipant), nameof(AddedAt));
        
        [JsonPropertyName("addedAt")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? AddedAt
        {
            get => _addedAt.GetValue();
            set => _addedAt.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _user.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
            _state.SetAccessPath(path, validateHasBeenSet);
            _theirTurn.SetAccessPath(path, validateHasBeenSet);
            _qualityGateSlots.SetAccessPath(path, validateHasBeenSet);
            _addedAt.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}