// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1563282+00:00
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
    public sealed class RepositoryState : Enumeration
    {
        private RepositoryState(string value) : base(value) { }
        
        public static readonly RepositoryState READY = new RepositoryState("READY");
        public static readonly RepositoryState INPROGRESS = new RepositoryState("IN_PROGRESS");
        public static readonly RepositoryState ERROR = new RepositoryState("ERROR");
    }
    
}
