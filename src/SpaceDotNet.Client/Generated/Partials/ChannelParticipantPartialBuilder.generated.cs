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

namespace SpaceDotNet.Client.ChannelParticipantPartialBuilder
{
    public static class ChannelParticipantPartialExtensions
    {
        public static Partial<ChannelParticipant> WithPrincipal(this Partial<ChannelParticipant> it)
            => it.AddFieldName("principal");
        
        public static Partial<ChannelParticipant> WithPrincipal(this Partial<ChannelParticipant> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("principal", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<ChannelParticipant> WithMessageCount(this Partial<ChannelParticipant> it)
            => it.AddFieldName("messageCount");
        
        public static Partial<ChannelParticipant> WithPendingMessageCount(this Partial<ChannelParticipant> it)
            => it.AddFieldName("pendingMessageCount");
        
    }
    
}
