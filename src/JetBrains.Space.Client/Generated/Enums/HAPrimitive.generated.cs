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
    public sealed class HAPrimitive : Enumeration
    {
        private HAPrimitive(string value) : base(value) { }
        
        public static readonly HAPrimitive Byte = new HAPrimitive("Byte");
        public static readonly HAPrimitive Short = new HAPrimitive("Short");
        public static readonly HAPrimitive Int = new HAPrimitive("Int");
        public static readonly HAPrimitive Long = new HAPrimitive("Long");
        public static readonly HAPrimitive Float = new HAPrimitive("Float");
        public static readonly HAPrimitive Double = new HAPrimitive("Double");
        public static readonly HAPrimitive Boolean = new HAPrimitive("Boolean");
        public static readonly HAPrimitive String = new HAPrimitive("String");
        public static readonly HAPrimitive Date = new HAPrimitive("Date");
        public static readonly HAPrimitive DateTime = new HAPrimitive("DateTime");
    }
    
}
