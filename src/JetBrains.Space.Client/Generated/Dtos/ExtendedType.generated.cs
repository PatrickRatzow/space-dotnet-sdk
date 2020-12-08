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
    public sealed class ExtendedType
         : IPropagatePropertyAccessPath
    {
        public ExtendedType() { }
        
        public ExtendedType(string key, string displayName, ExtendedTypeScopeType scopeType, string? apiClassName = null)
        {
            Key = key;
            DisplayName = displayName;
            ApiClassName = apiClassName;
            ScopeType = scopeType;
        }
        
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(ExtendedType), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(ExtendedType), nameof(DisplayName));
        
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName
        {
            get => _displayName.GetValue();
            set => _displayName.SetValue(value);
        }
    
        private PropertyValue<string?> _apiClassName = new PropertyValue<string?>(nameof(ExtendedType), nameof(ApiClassName));
        
        [JsonPropertyName("apiClassName")]
        public string? ApiClassName
        {
            get => _apiClassName.GetValue();
            set => _apiClassName.SetValue(value);
        }
    
        private PropertyValue<ExtendedTypeScopeType> _scopeType = new PropertyValue<ExtendedTypeScopeType>(nameof(ExtendedType), nameof(ScopeType));
        
        [Required]
        [JsonPropertyName("scopeType")]
        public ExtendedTypeScopeType ScopeType
        {
            get => _scopeType.GetValue();
            set => _scopeType.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _displayName.SetAccessPath(path, validateHasBeenSet);
            _apiClassName.SetAccessPath(path, validateHasBeenSet);
            _scopeType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
