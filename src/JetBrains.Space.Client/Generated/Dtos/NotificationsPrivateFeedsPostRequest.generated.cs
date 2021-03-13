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
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public class NotificationsPrivateFeedsPostRequest
         : IPropagatePropertyAccessPath
    {
        public NotificationsPrivateFeedsPostRequest() { }
        
        public NotificationsPrivateFeedsPostRequest(ProfileIdentifier profile, string name, string icon, PrivateFeedColor color)
        {
            Profile = profile;
            Name = name;
            Icon = icon;
            Color = color;
        }
        
        private PropertyValue<ProfileIdentifier> _profile = new PropertyValue<ProfileIdentifier>(nameof(NotificationsPrivateFeedsPostRequest), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public ProfileIdentifier Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(NotificationsPrivateFeedsPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _icon = new PropertyValue<string>(nameof(NotificationsPrivateFeedsPostRequest), nameof(Icon));
        
        [Required]
        [JsonPropertyName("icon")]
        public string Icon
        {
            get => _icon.GetValue();
            set => _icon.SetValue(value);
        }
    
        private PropertyValue<PrivateFeedColor> _color = new PropertyValue<PrivateFeedColor>(nameof(NotificationsPrivateFeedsPostRequest), nameof(Color));
        
        [Required]
        [JsonPropertyName("color")]
        public PrivateFeedColor Color
        {
            get => _color.GetValue();
            set => _color.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
            _color.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
