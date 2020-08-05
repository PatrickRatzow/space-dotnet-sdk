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

namespace SpaceDotNet.Client
{
    public sealed class MergeRequestReviewerDto
         : IPropagatePropertyAccessPath
    {
        public MergeRequestReviewerDto() { }
        
        public MergeRequestReviewerDto(string profileId, CodeReviewParticipantQualityGateSlotDto? qualityGateSlot = null)
        {
            ProfileId = profileId;
            QualityGateSlot = qualityGateSlot;
        }
        
        private PropertyValue<string> _profileId = new PropertyValue<string>(nameof(MergeRequestReviewerDto), nameof(ProfileId));
        
        [Required]
        [JsonPropertyName("profileId")]
        public string ProfileId
        {
            get { return _profileId.GetValue(); }
            set { _profileId.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewParticipantQualityGateSlotDto?> _qualityGateSlot = new PropertyValue<CodeReviewParticipantQualityGateSlotDto?>(nameof(MergeRequestReviewerDto), nameof(QualityGateSlot));
        
        [JsonPropertyName("qualityGateSlot")]
        public CodeReviewParticipantQualityGateSlotDto? QualityGateSlot
        {
            get { return _qualityGateSlot.GetValue(); }
            set { _qualityGateSlot.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profileId.SetAccessPath(path, validateHasBeenSet);
            _qualityGateSlot.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
