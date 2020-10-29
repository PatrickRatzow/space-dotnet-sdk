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
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class EntityType
         : IPropagatePropertyAccessPath
    {
        public EntityType() { }
        
        public EntityType(string key, string? displayName = null, string? groupName = null)
        {
            Key = key;
            DisplayName = displayName;
            GroupName = groupName;
        }
        
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(EntityType), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string?> _displayName = new PropertyValue<string?>(nameof(EntityType), nameof(DisplayName));
        
        [JsonPropertyName("displayName")]
        public string? DisplayName
        {
            get { return _displayName.GetValue(); }
            set { _displayName.SetValue(value); }
        }
    
        private PropertyValue<string?> _groupName = new PropertyValue<string?>(nameof(EntityType), nameof(GroupName));
        
        [JsonPropertyName("groupName")]
        public string? GroupName
        {
            get { return _groupName.GetValue(); }
            set { _groupName.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _displayName.SetAccessPath(path, validateHasBeenSet);
            _groupName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
