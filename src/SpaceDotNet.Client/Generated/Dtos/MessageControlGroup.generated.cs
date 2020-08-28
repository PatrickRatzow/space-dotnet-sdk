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
    public sealed class MessageControlGroup
         : MessageElement, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageControlGroup";
        
        public MessageControlGroup() { }
        
        public MessageControlGroup(List<MessageControlElement> elements)
        {
            Elements = elements;
        }
        
        private PropertyValue<List<MessageControlElement>> _elements = new PropertyValue<List<MessageControlElement>>(nameof(MessageControlGroup), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<MessageControlElement> Elements
        {
            get { return _elements.GetValue(); }
            set { _elements.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _elements.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
