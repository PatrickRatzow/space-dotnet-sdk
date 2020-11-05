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
    public sealed class TodoContent
         : TodoItemContent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "TodoContent";
        
        public TodoContent() { }
        
        public TodoContent(string originalText, string text, string? link = null, TodoItemContentKind? kind = null, CPrincipal? principal = null, long? time = null)
        {
            OriginalText = originalText;
            Link = link;
            Kind = kind;
            Principal = principal;
            Time = time;
            Text = text;
        }
        
        private PropertyValue<string> _originalText = new PropertyValue<string>(nameof(TodoContent), nameof(OriginalText));
        
        [Required]
        [JsonPropertyName("originalText")]
        public string OriginalText
        {
            get => _originalText.GetValue();
            set => _originalText.SetValue(value);
        }
    
        private PropertyValue<string?> _link = new PropertyValue<string?>(nameof(TodoContent), nameof(Link));
        
        [JsonPropertyName("link")]
        public string? Link
        {
            get => _link.GetValue();
            set => _link.SetValue(value);
        }
    
        private PropertyValue<TodoItemContentKind?> _kind = new PropertyValue<TodoItemContentKind?>(nameof(TodoContent), nameof(Kind));
        
        [JsonPropertyName("kind")]
        public TodoItemContentKind? Kind
        {
            get => _kind.GetValue();
            set => _kind.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _principal = new PropertyValue<CPrincipal?>(nameof(TodoContent), nameof(Principal));
        
        [JsonPropertyName("principal")]
        public CPrincipal? Principal
        {
            get => _principal.GetValue();
            set => _principal.SetValue(value);
        }
    
        private PropertyValue<long?> _time = new PropertyValue<long?>(nameof(TodoContent), nameof(Time));
        
        [JsonPropertyName("time")]
        public long? Time
        {
            get => _time.GetValue();
            set => _time.SetValue(value);
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(TodoContent), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _originalText.SetAccessPath(path, validateHasBeenSet);
            _link.SetAccessPath(path, validateHasBeenSet);
            _kind.SetAccessPath(path, validateHasBeenSet);
            _principal.SetAccessPath(path, validateHasBeenSet);
            _time.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}