// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1584896+00:00
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
    public sealed class VolumeState : Enumeration
    {
        private VolumeState(string value) : base(value) { }
        
        public static readonly VolumeState UNKNOWN = new VolumeState("UNKNOWN");
        public static readonly VolumeState CREATING = new VolumeState("CREATING");
        public static readonly VolumeState AVAILABLE = new VolumeState("AVAILABLE");
        public static readonly VolumeState INUSE = new VolumeState("IN_USE");
        public static readonly VolumeState DELETING = new VolumeState("DELETING");
        public static readonly VolumeState DELETED = new VolumeState("DELETED");
        public static readonly VolumeState ERROR = new VolumeState("ERROR");
    }
    
}
