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
    public sealed class PostMessageAction
         : MessageAction, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "PostMessageAction";
        
        public PostMessageAction() { }
        
        public PostMessageAction(string actionId, string payload)
        {
            ActionId = actionId;
            Payload = payload;
        }
        
        private PropertyValue<string> _actionId = new PropertyValue<string>(nameof(PostMessageAction), nameof(ActionId));
        
        [Required]
        [JsonPropertyName("actionId")]
        public string ActionId
        {
            get => _actionId.GetValue();
            set => _actionId.SetValue(value);
        }
    
        private PropertyValue<string> _payload = new PropertyValue<string>(nameof(PostMessageAction), nameof(Payload));
        
        [Required]
        [JsonPropertyName("payload")]
        public string Payload
        {
            get => _payload.GetValue();
            set => _payload.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _actionId.SetAccessPath(path, validateHasBeenSet);
            _payload.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}