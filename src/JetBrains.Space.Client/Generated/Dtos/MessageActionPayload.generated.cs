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
    public sealed class MessageActionPayload
         : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageActionPayload";
        
        public MessageActionPayload() { }
        
        public MessageActionPayload(string actionId, string actionValue, MessageContext message, string userId, string? accessToken = null, string? verificationToken = null)
        {
            ActionId = actionId;
            ActionValue = actionValue;
            Message = message;
            AccessToken = accessToken;
            VerificationToken = verificationToken;
            UserId = userId;
        }
        
        private PropertyValue<string> _actionId = new PropertyValue<string>(nameof(MessageActionPayload), nameof(ActionId));
        
        [Required]
        [JsonPropertyName("actionId")]
        public string ActionId
        {
            get => _actionId.GetValue();
            set => _actionId.SetValue(value);
        }
    
        private PropertyValue<string> _actionValue = new PropertyValue<string>(nameof(MessageActionPayload), nameof(ActionValue));
        
        [Required]
        [JsonPropertyName("actionValue")]
        public string ActionValue
        {
            get => _actionValue.GetValue();
            set => _actionValue.SetValue(value);
        }
    
        private PropertyValue<MessageContext> _message = new PropertyValue<MessageContext>(nameof(MessageActionPayload), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public MessageContext Message
        {
            get => _message.GetValue();
            set => _message.SetValue(value);
        }
    
        private PropertyValue<string?> _accessToken = new PropertyValue<string?>(nameof(MessageActionPayload), nameof(AccessToken));
        
        [JsonPropertyName("accessToken")]
        public string? AccessToken
        {
            get => _accessToken.GetValue();
            set => _accessToken.SetValue(value);
        }
    
        private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(MessageActionPayload), nameof(VerificationToken));
        
        [JsonPropertyName("verificationToken")]
        public string? VerificationToken
        {
            get => _verificationToken.GetValue();
            set => _verificationToken.SetValue(value);
        }
    
        private PropertyValue<string> _userId = new PropertyValue<string>(nameof(MessageActionPayload), nameof(UserId));
        
        [Required]
        [JsonPropertyName("userId")]
        public string UserId
        {
            get => _userId.GetValue();
            set => _userId.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _actionId.SetAccessPath(path, validateHasBeenSet);
            _actionValue.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
            _accessToken.SetAccessPath(path, validateHasBeenSet);
            _verificationToken.SetAccessPath(path, validateHasBeenSet);
            _userId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
