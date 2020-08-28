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
    public sealed class MetricsProp
         : IPropagatePropertyAccessPath
    {
        public MetricsProp() { }
        
        public MetricsProp(string key, string value)
        {
            Key = key;
            Value = value;
        }
        
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(MetricsProp), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(MetricsProp), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
