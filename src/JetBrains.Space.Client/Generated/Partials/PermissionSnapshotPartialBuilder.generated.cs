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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.PermissionSnapshotPartialBuilder
{
    public static class PermissionSnapshotPartialExtensions
    {
        public static Partial<PermissionSnapshot> WithId(this Partial<PermissionSnapshot> it)
            => it.AddFieldName("id");
        
        public static Partial<PermissionSnapshot> WithTimestamp(this Partial<PermissionSnapshot> it)
            => it.AddFieldName("timestamp");
        
        public static Partial<PermissionSnapshot> WithName(this Partial<PermissionSnapshot> it)
            => it.AddFieldName("name");
        
        public static Partial<PermissionSnapshot> WithVersion(this Partial<PermissionSnapshot> it)
            => it.AddFieldName("version");
        
        public static Partial<PermissionSnapshot> WithSize(this Partial<PermissionSnapshot> it)
            => it.AddFieldName("size");
        
    }
    
}