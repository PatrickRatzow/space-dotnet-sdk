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
    public sealed class MCMessage
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCMessage";
        
        public MCMessage() { }
        
        public MCMessage(string style, List<MCElement> content, MCOutline? outline = null, string? serviceId = null, string? supplementaryData = null, M2ItemContentDetails? extension = null)
        {
            Style = style;
            Outline = outline;
            Content = content;
            ServiceId = serviceId;
            SupplementaryData = supplementaryData;
            Extension = extension;
        }
        
        private PropertyValue<string> _style = new PropertyValue<string>(nameof(MCMessage), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public string Style
        {
            get { return _style.GetValue(); }
            set { _style.SetValue(value); }
        }
    
        private PropertyValue<MCOutline?> _outline = new PropertyValue<MCOutline?>(nameof(MCMessage), nameof(Outline));
        
        [JsonPropertyName("outline")]
        public MCOutline? Outline
        {
            get { return _outline.GetValue(); }
            set { _outline.SetValue(value); }
        }
    
        private PropertyValue<List<MCElement>> _content = new PropertyValue<List<MCElement>>(nameof(MCMessage), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public List<MCElement> Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<string?> _serviceId = new PropertyValue<string?>(nameof(MCMessage), nameof(ServiceId));
        
        [JsonPropertyName("serviceId")]
        public string? ServiceId
        {
            get { return _serviceId.GetValue(); }
            set { _serviceId.SetValue(value); }
        }
    
        private PropertyValue<string?> _supplementaryData = new PropertyValue<string?>(nameof(MCMessage), nameof(SupplementaryData));
        
        [JsonPropertyName("supplementaryData")]
        public string? SupplementaryData
        {
            get { return _supplementaryData.GetValue(); }
            set { _supplementaryData.SetValue(value); }
        }
    
        private PropertyValue<M2ItemContentDetails?> _extension = new PropertyValue<M2ItemContentDetails?>(nameof(MCMessage), nameof(Extension));
        
        [JsonPropertyName("extension")]
        public M2ItemContentDetails? Extension
        {
            get { return _extension.GetValue(); }
            set { _extension.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _style.SetAccessPath(path, validateHasBeenSet);
            _outline.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _serviceId.SetAccessPath(path, validateHasBeenSet);
            _supplementaryData.SetAccessPath(path, validateHasBeenSet);
            _extension.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
