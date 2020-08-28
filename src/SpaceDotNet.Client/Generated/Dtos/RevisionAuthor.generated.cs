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
    public sealed class RevisionAuthor
         : IPropagatePropertyAccessPath
    {
        public RevisionAuthor() { }
        
        public RevisionAuthor(string authorName, TDMemberProfile? profile = null)
        {
            AuthorName = authorName;
            Profile = profile;
        }
        
        private PropertyValue<string> _authorName = new PropertyValue<string>(nameof(RevisionAuthor), nameof(AuthorName));
        
        [Required]
        [JsonPropertyName("authorName")]
        public string AuthorName
        {
            get { return _authorName.GetValue(); }
            set { _authorName.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile?> _profile = new PropertyValue<TDMemberProfile?>(nameof(RevisionAuthor), nameof(Profile));
        
        [JsonPropertyName("profile")]
        public TDMemberProfile? Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _authorName.SetAccessPath(path, validateHasBeenSet);
            _profile.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
