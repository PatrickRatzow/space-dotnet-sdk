// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class BillingFeedChannelDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "BillingFeedChannel";
        
        public BillingFeedChannelDto() { }
        
        public BillingFeedChannelDto(ChannelSpecificDefaultsDto? notificationDefaults = null)
        {
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<ChannelSpecificDefaultsDto?> _notificationDefaults = new PropertyValue<ChannelSpecificDefaultsDto?>(nameof(BillingFeedChannelDto), nameof(NotificationDefaults));
        
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto? NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
