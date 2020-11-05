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
    public sealed class HADefaultValueMap
         : HADefaultValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_DefaultValue.Map";
        
        public HADefaultValueMap() { }
        
        public HADefaultValueMap(Dictionary<string, HADefaultValue> elements)
        {
            Elements = elements;
        }
        
        private PropertyValue<Dictionary<string, HADefaultValue>> _elements = new PropertyValue<Dictionary<string, HADefaultValue>>(nameof(HADefaultValueMap), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public Dictionary<string, HADefaultValue> Elements
        {
            get => _elements.GetValue();
            set => _elements.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _elements.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}