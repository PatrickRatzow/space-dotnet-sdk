// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4920649+00:00
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

namespace SpaceDotNet.Client.M2ChannelContentCodeReviewDiscussionExtensions
{
    public static class M2ChannelContentCodeReviewDiscussionDtoPartialExtensions
    {
        public static Partial<M2ChannelContentCodeReviewDiscussionDto> WithCodeReviewDiscussion(this Partial<M2ChannelContentCodeReviewDiscussionDto> it)
            => it.AddFieldName("codeReviewDiscussion");
        
        public static Partial<M2ChannelContentCodeReviewDiscussionDto> WithNotificationDefaults(this Partial<M2ChannelContentCodeReviewDiscussionDto> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentCodeReviewDiscussionDto> WithNotificationDefaults(this Partial<M2ChannelContentCodeReviewDiscussionDto> it, Func<Partial<ChannelSpecificDefaultsDto>, Partial<ChannelSpecificDefaultsDto>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaultsDto>()));
        
    }
    
}
