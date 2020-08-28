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
    public class AuthModulesPostRequest
         : IPropagatePropertyAccessPath
    {
        public AuthModulesPostRequest() { }
        
        public AuthModulesPostRequest(string key, string name, bool enabled, ESAuthModuleSettings settings)
        {
            Key = key;
            Name = name;
            IsEnabled = enabled;
            Settings = settings;
        }
        
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(AuthModulesPostRequest), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(AuthModulesPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(AuthModulesPostRequest), nameof(IsEnabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool IsEnabled
        {
            get { return _enabled.GetValue(); }
            set { _enabled.SetValue(value); }
        }
    
        private PropertyValue<ESAuthModuleSettings> _settings = new PropertyValue<ESAuthModuleSettings>(nameof(AuthModulesPostRequest), nameof(Settings));
        
        [Required]
        [JsonPropertyName("settings")]
        public ESAuthModuleSettings Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
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
