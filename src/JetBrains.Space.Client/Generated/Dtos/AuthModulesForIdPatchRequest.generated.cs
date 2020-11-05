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
    public class AuthModulesForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public AuthModulesForIdPatchRequest() { }
        
        public AuthModulesForIdPatchRequest(string? key = null, string? name = null, bool? enabled = null, ESAuthModuleSettings? settings = null)
        {
            Key = key;
            Name = name;
            IsEnabled = enabled;
            Settings = settings;
        }
        
        private PropertyValue<string?> _key = new PropertyValue<string?>(nameof(AuthModulesForIdPatchRequest), nameof(Key));
        
        [JsonPropertyName("key")]
        public string? Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(AuthModulesForIdPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<bool?> _enabled = new PropertyValue<bool?>(nameof(AuthModulesForIdPatchRequest), nameof(IsEnabled));
        
        [JsonPropertyName("enabled")]
        public bool? IsEnabled
        {
            get => _enabled.GetValue();
            set => _enabled.SetValue(value);
        }
    
        private PropertyValue<ESAuthModuleSettings?> _settings = new PropertyValue<ESAuthModuleSettings?>(nameof(AuthModulesForIdPatchRequest), nameof(Settings));
        
        [JsonPropertyName("settings")]
        public ESAuthModuleSettings? Settings
        {
            get => _settings.GetValue();
            set => _settings.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _enabled.SetAccessPath(path, validateHasBeenSet);
            _settings.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}