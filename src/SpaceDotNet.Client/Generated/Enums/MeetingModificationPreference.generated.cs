// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1537980+00:00
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
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class MeetingModificationPreference : Enumeration
    {
        private MeetingModificationPreference(string value) : base(value) { }
        
        public static readonly MeetingModificationPreference ORGANIZER = new MeetingModificationPreference("ORGANIZER");
        public static readonly MeetingModificationPreference PARTICIPANTS = new MeetingModificationPreference("PARTICIPANTS");
        public static readonly MeetingModificationPreference EVERYONE = new MeetingModificationPreference("EVERYONE");
    }
    
}
