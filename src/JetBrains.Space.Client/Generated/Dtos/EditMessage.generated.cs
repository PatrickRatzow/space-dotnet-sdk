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
    public sealed class EditMessage
         : ChatModification, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "EditMessage";
        
        public EditMessage() { }
        
        public EditMessage(string text, string id, List<Attachment>? attachments = null)
        {
            Text = text;
            Id = id;
            Attachments = attachments;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(EditMessage), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(EditMessage), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<List<Attachment>?> _attachments = new PropertyValue<List<Attachment>?>(nameof(EditMessage), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<Attachment>? Attachments
        {
            get => _attachments.GetValue();
            set => _attachments.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}