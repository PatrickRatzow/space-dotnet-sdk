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

namespace SpaceDotNet.Client.BilledItemsPartialBuilder
{
    public static class BilledItemsPartialExtensions
    {
        public static Partial<BilledItems> WithUsers(this Partial<BilledItems> it)
            => it.AddFieldName("users");
        
        public static Partial<BilledItems> WithUsers(this Partial<BilledItems> it, Func<Partial<BilledItem>, Partial<BilledItem>> partialBuilder)
            => it.AddFieldName("users", partialBuilder(new Partial<BilledItem>(it)));
        
        public static Partial<BilledItems> WithChatMessages(this Partial<BilledItems> it)
            => it.AddFieldName("chatMessages");
        
        public static Partial<BilledItems> WithChatMessages(this Partial<BilledItems> it, Func<Partial<BilledItem>, Partial<BilledItem>> partialBuilder)
            => it.AddFieldName("chatMessages", partialBuilder(new Partial<BilledItem>(it)));
        
        public static Partial<BilledItems> WithApps(this Partial<BilledItems> it)
            => it.AddFieldName("apps");
        
        public static Partial<BilledItems> WithApps(this Partial<BilledItems> it, Func<Partial<BilledItem>, Partial<BilledItem>> partialBuilder)
            => it.AddFieldName("apps", partialBuilder(new Partial<BilledItem>(it)));
        
    }
    
}
