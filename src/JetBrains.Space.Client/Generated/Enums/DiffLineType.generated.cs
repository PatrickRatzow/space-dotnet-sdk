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
    public sealed class DiffLineType : Enumeration
    {
        private DiffLineType(string value) : base(value) { }
        
        public static readonly DiffLineType ADDED = new DiffLineType("ADDED");
        public static readonly DiffLineType DELETED = new DiffLineType("DELETED");
        public static readonly DiffLineType MODIFIED = new DiffLineType("MODIFIED");
        public static readonly DiffLineType CONFLICTOLD = new DiffLineType("CONFLICT_OLD");
        public static readonly DiffLineType CONFLICTNEW = new DiffLineType("CONFLICT_NEW");
    }
    
}
