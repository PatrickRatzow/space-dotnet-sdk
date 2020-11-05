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
    public sealed class M2ChannelContentApplication
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentApplication";
        
        public M2ChannelContentApplication() { }
        
        public M2ChannelContentApplication(ESService service, ChannelSpecificDefaults notificationDefaults)
        {
            Service = service;
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<ESService> _service = new PropertyValue<ESService>(nameof(M2ChannelContentApplication), nameof(Service));
        
        [Required]
        [JsonPropertyName("service")]
        public ESService Service
        {
            get => _service.GetValue();
            set => _service.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentApplication), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _service.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}