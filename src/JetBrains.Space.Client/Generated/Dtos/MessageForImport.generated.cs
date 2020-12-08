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
    public sealed class MessageForImport
         : IPropagatePropertyAccessPath
    {
        public MessageForImport() { }
        
        public MessageForImport(string authorPrincipalId, string text, long createdAtUtc, List<AttachmentIn>? attachments = null)
        {
            AuthorPrincipalId = authorPrincipalId;
            Text = text;
            CreatedAtUtc = createdAtUtc;
            Attachments = attachments;
        }
        
        private PropertyValue<string> _authorPrincipalId = new PropertyValue<string>(nameof(MessageForImport), nameof(AuthorPrincipalId));
        
        [Required]
        [JsonPropertyName("authorPrincipalId")]
        public string AuthorPrincipalId
        {
            get => _authorPrincipalId.GetValue();
            set => _authorPrincipalId.SetValue(value);
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageForImport), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<long> _createdAtUtc = new PropertyValue<long>(nameof(MessageForImport), nameof(CreatedAtUtc));
        
        [Required]
        [JsonPropertyName("createdAtUtc")]
        public long CreatedAtUtc
        {
            get => _createdAtUtc.GetValue();
            set => _createdAtUtc.SetValue(value);
        }
    
        private PropertyValue<List<AttachmentIn>?> _attachments = new PropertyValue<List<AttachmentIn>?>(nameof(MessageForImport), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<AttachmentIn>? Attachments
        {
            get => _attachments.GetValue();
            set => _attachments.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _authorPrincipalId.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _createdAtUtc.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
