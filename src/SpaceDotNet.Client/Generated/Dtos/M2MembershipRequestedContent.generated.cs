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
    public sealed class M2MembershipRequestedContent
         : M2MembershipContent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "M2MembershipRequestedContent";
        
        public M2MembershipRequestedContent() { }
        
        public M2MembershipRequestedContent(TDMembership membership, bool leave)
        {
            Membership = membership;
            IsLeave = leave;
        }
        
        private PropertyValue<TDMembership> _membership = new PropertyValue<TDMembership>(nameof(M2MembershipRequestedContent), nameof(Membership));
        
        [Required]
        [JsonPropertyName("membership")]
        public TDMembership Membership
        {
            get { return _membership.GetValue(); }
            set { _membership.SetValue(value); }
        }
    
        private PropertyValue<bool> _leave = new PropertyValue<bool>(nameof(M2MembershipRequestedContent), nameof(IsLeave));
        
        [Required]
        [JsonPropertyName("leave")]
        public bool IsLeave
        {
            get { return _leave.GetValue(); }
            set { _leave.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _membership.SetAccessPath(path, validateHasBeenSet);
            _leave.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
