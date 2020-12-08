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
    public sealed class AbsenceApproval
         : IPropagatePropertyAccessPath
    {
        public AbsenceApproval() { }
        
        public AbsenceApproval(bool approved, TDMemberProfile approvedBy, DateTime approvedAt)
        {
            IsApproved = approved;
            ApprovedBy = approvedBy;
            ApprovedAt = approvedAt;
        }
        
        private PropertyValue<bool> _approved = new PropertyValue<bool>(nameof(AbsenceApproval), nameof(IsApproved));
        
        [Required]
        [JsonPropertyName("approved")]
        public bool IsApproved
        {
            get => _approved.GetValue();
            set => _approved.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile> _approvedBy = new PropertyValue<TDMemberProfile>(nameof(AbsenceApproval), nameof(ApprovedBy));
        
        [Required]
        [JsonPropertyName("approvedBy")]
        public TDMemberProfile ApprovedBy
        {
            get => _approvedBy.GetValue();
            set => _approvedBy.SetValue(value);
        }
    
        private PropertyValue<DateTime> _approvedAt = new PropertyValue<DateTime>(nameof(AbsenceApproval), nameof(ApprovedAt));
        
        [Required]
        [JsonPropertyName("approvedAt")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime ApprovedAt
        {
            get => _approvedAt.GetValue();
            set => _approvedAt.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _approved.SetAccessPath(path, validateHasBeenSet);
            _approvedBy.SetAccessPath(path, validateHasBeenSet);
            _approvedAt.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
