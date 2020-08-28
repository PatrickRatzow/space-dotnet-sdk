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

namespace SpaceDotNet.Client.MessageTextPartialBuilder
{
    public static class MessageTextPartialExtensions
    {
        public static Partial<MessageText> WithAccessory(this Partial<MessageText> it)
            => it.AddFieldName("accessory");
        
        public static Partial<MessageText> WithAccessory(this Partial<MessageText> it, Func<Partial<MessageAccessoryElement>, Partial<MessageAccessoryElement>> partialBuilder)
            => it.AddFieldName("accessory", partialBuilder(new Partial<MessageAccessoryElement>(it)));
        
        public static Partial<MessageText> WithContent(this Partial<MessageText> it)
            => it.AddFieldName("content");
        
    }
    
}
