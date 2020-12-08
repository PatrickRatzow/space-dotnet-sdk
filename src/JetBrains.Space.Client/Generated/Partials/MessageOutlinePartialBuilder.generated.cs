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

namespace JetBrains.Space.Client.MessageOutlinePartialBuilder
{
    public static class MessageOutlinePartialExtensions
    {
        public static Partial<MessageOutline> WithIcon(this Partial<MessageOutline> it)
            => it.AddFieldName("icon");
        
        public static Partial<MessageOutline> WithIcon(this Partial<MessageOutline> it, Func<Partial<ApiIcon>, Partial<ApiIcon>> partialBuilder)
            => it.AddFieldName("icon", partialBuilder(new Partial<ApiIcon>(it)));
        
        public static Partial<MessageOutline> WithText(this Partial<MessageOutline> it)
            => it.AddFieldName("text");
        
    }
    
}
