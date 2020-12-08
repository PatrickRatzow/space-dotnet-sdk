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
    public sealed class ESApplicationPassword
         : IPropagatePropertyAccessPath
    {
        public ESApplicationPassword() { }
        
        public ESApplicationPassword(string id, TDMemberProfile profile, string name, string scope, DateTime created, AccessRecord? lastAccess = null)
        {
            Id = id;
            Profile = profile;
            Name = name;
            Scope = scope;
            Created = created;
            LastAccess = lastAccess;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESApplicationPassword), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(ESApplicationPassword), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESApplicationPassword), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _scope = new PropertyValue<string>(nameof(ESApplicationPassword), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public string Scope
        {
            get => _scope.GetValue();
            set => _scope.SetValue(value);
        }
    
        private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(ESApplicationPassword), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<AccessRecord?> _lastAccess = new PropertyValue<AccessRecord?>(nameof(ESApplicationPassword), nameof(LastAccess));
        
        [JsonPropertyName("lastAccess")]
        public AccessRecord? LastAccess
        {
            get => _lastAccess.GetValue();
            set => _lastAccess.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _profile.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _scope.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _lastAccess.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
