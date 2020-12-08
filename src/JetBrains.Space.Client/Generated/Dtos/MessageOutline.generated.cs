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
    public sealed class MessageOutline
         : IPropagatePropertyAccessPath
    {
        public MessageOutline() { }
        
        public MessageOutline(string text, ApiIcon? icon = null)
        {
            Icon = icon;
            Text = text;
        }
        
        private PropertyValue<ApiIcon?> _icon = new PropertyValue<ApiIcon?>(nameof(MessageOutline), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public ApiIcon? Icon
        {
            get => _icon.GetValue();
            set => _icon.SetValue(value);
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageOutline), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _icon.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
