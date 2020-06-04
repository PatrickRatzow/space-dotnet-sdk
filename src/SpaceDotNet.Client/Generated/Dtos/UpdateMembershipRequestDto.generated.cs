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
    public class UpdateMembershipRequestDto
    {
        [JsonPropertyName("memberId")]
        public string? MemberId { get; set; }
    
        [JsonPropertyName("teamId")]
        public string? TeamId { get; set; }
    
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
    
        [JsonPropertyName("lead")]
        public bool? Lead { get; set; }
    
        [JsonPropertyName("managerId")]
        public string? ManagerId { get; set; }
    
        [JsonPropertyName("since")]
        public SpaceDate? Since { get; set; }
    
        [JsonPropertyName("till")]
        public SpaceDate? Till { get; set; }
    
        [JsonPropertyName("activeSince")]
        public SpaceTime? ActiveSince { get; set; }
    
        [JsonPropertyName("activeTill")]
        public SpaceTime? ActiveTill { get; set; }
    
        [JsonPropertyName("previousMembershipId")]
        public string? PreviousMembershipId { get; set; }
    
        [Required]
        [JsonPropertyName("requiresApproval")]
        public bool RequiresApproval { get; set; }
    
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues { get; set; }
    
    }
    
}
