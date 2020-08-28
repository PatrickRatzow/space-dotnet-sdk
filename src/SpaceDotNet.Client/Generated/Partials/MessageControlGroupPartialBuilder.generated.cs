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

namespace SpaceDotNet.Client.MessageControlGroupPartialBuilder
{
    public static class MessageControlGroupPartialExtensions
    {
        public static Partial<MessageControlGroup> WithElements(this Partial<MessageControlGroup> it)
            => it.AddFieldName("elements");
        
        public static Partial<MessageControlGroup> WithElements(this Partial<MessageControlGroup> it, Func<Partial<MessageControlElement>, Partial<MessageControlElement>> partialBuilder)
            => it.AddFieldName("elements", partialBuilder(new Partial<MessageControlElement>(it)));
        
    }
    
}
