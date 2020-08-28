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
    public sealed class PRPrivateProject
         : IPropagatePropertyAccessPath
    {
        public PRPrivateProject() { }
        
        public PRPrivateProject(ProjectKey key, string name, bool accessAllowed, List<TDMemberProfile> admins)
        {
            Key = key;
            Name = name;
            IsAccessAllowed = accessAllowed;
            Admins = admins;
        }
        
        private PropertyValue<ProjectKey> _key = new PropertyValue<ProjectKey>(nameof(PRPrivateProject), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public ProjectKey Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PRPrivateProject), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool> _accessAllowed = new PropertyValue<bool>(nameof(PRPrivateProject), nameof(IsAccessAllowed));
        
        [Required]
        [JsonPropertyName("accessAllowed")]
        public bool IsAccessAllowed
        {
            get { return _accessAllowed.GetValue(); }
            set { _accessAllowed.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfile>> _admins = new PropertyValue<List<TDMemberProfile>>(nameof(PRPrivateProject), nameof(Admins));
        
        [Required]
        [JsonPropertyName("admins")]
        public List<TDMemberProfile> Admins
        {
            get { return _admins.GetValue(); }
            set { _admins.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _accessAllowed.SetAccessPath(path, validateHasBeenSet);
            _admins.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
