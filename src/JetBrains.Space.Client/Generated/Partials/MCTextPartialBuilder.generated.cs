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

namespace JetBrains.Space.Client.MCTextPartialBuilder
{
    public static class MCTextPartialExtensions
    {
        public static Partial<MCText> WithContent(this Partial<MCText> it)
            => it.AddFieldName("content");
        
        public static Partial<MCText> WithIsMarkdown(this Partial<MCText> it)
            => it.AddFieldName("markdown");
        
        public static Partial<MCText> WithAccessory(this Partial<MCText> it)
            => it.AddFieldName("accessory");
        
        public static Partial<MCText> WithAccessory(this Partial<MCText> it, Func<Partial<MCElement>, Partial<MCElement>> partialBuilder)
            => it.AddFieldName("accessory", partialBuilder(new Partial<MCElement>(it)));
        
    }
    
}
