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

namespace SpaceDotNet.Client.ChannelSpecificDefaultsExtensions
{
    public static class ChannelSpecificDefaultsDtoPartialExtensions
    {
        public static Partial<ChannelSpecificDefaultsDto> WithFilter(this Partial<ChannelSpecificDefaultsDto> it)
            => it.AddFieldName("filter");
        
        public static Partial<ChannelSpecificDefaultsDto> WithPush(this Partial<ChannelSpecificDefaultsDto> it)
            => it.AddFieldName("push");
        
        public static Partial<ChannelSpecificDefaultsDto> WithEmail(this Partial<ChannelSpecificDefaultsDto> it)
            => it.AddFieldName("email");
        
    }
    
}