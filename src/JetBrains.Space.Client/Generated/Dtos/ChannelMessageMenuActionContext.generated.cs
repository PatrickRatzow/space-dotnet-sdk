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
    public sealed class ChannelMessageMenuActionContext
         : MenuActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ChannelMessageMenuActionContext";
        
        public ChannelMessageMenuActionContext() { }
        
        public ChannelMessageMenuActionContext(string menuId, string messageId, string? channelId = null)
        {
            MenuId = menuId;
            ChannelId = channelId;
            MessageId = messageId;
        }
        
        private PropertyValue<string> _menuId = new PropertyValue<string>(nameof(ChannelMessageMenuActionContext), nameof(MenuId));
        
        [Required]
        [JsonPropertyName("menuId")]
        public string MenuId
        {
            get => _menuId.GetValue();
            set => _menuId.SetValue(value);
        }
    
        private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(ChannelMessageMenuActionContext), nameof(ChannelId));
        
        [JsonPropertyName("channelId")]
        public string? ChannelId
        {
            get => _channelId.GetValue();
            set => _channelId.SetValue(value);
        }
    
        private PropertyValue<string> _messageId = new PropertyValue<string>(nameof(ChannelMessageMenuActionContext), nameof(MessageId));
        
        [Required]
        [JsonPropertyName("messageId")]
        public string MessageId
        {
            get => _messageId.GetValue();
            set => _messageId.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _menuId.SetAccessPath(path, validateHasBeenSet);
            _channelId.SetAccessPath(path, validateHasBeenSet);
            _messageId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}