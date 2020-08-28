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
    public sealed class FTSProfile
         : IPropagatePropertyAccessPath
    {
        public FTSProfile() { }
        
        public FTSProfile(FTSUser profile, List<FTSSnippet> snippets, TDMemberProfile member)
        {
            Profile = profile;
            Snippets = snippets;
            Member = member;
        }
        
        private PropertyValue<FTSUser> _profile = new PropertyValue<FTSUser>(nameof(FTSProfile), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public FTSUser Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<List<FTSSnippet>> _snippets = new PropertyValue<List<FTSSnippet>>(nameof(FTSProfile), nameof(Snippets));
        
        [Required]
        [JsonPropertyName("snippets")]
        public List<FTSSnippet> Snippets
        {
            get { return _snippets.GetValue(); }
            set { _snippets.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(FTSProfile), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfile Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _snippets.SetAccessPath(path, validateHasBeenSet);
            _member.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
