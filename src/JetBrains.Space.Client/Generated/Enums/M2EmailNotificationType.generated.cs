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
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class M2EmailNotificationType : Enumeration
    {
        private M2EmailNotificationType(string value) : base(value) { }
        
        public static readonly M2EmailNotificationType INSTANT = new M2EmailNotificationType("INSTANT");
        public static readonly M2EmailNotificationType DELAYED = new M2EmailNotificationType("DELAYED");
        public static readonly M2EmailNotificationType NONE = new M2EmailNotificationType("NONE");
    }
    
}
