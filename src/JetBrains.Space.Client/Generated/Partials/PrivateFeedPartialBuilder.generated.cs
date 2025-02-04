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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.PrivateFeedPartialBuilder
{
    public static class PrivateFeedPartialExtensions
    {
        public static Partial<PrivateFeed> WithId(this Partial<PrivateFeed> it)
            => it.AddFieldName("id");
        
        public static Partial<PrivateFeed> WithName(this Partial<PrivateFeed> it)
            => it.AddFieldName("name");
        
        public static Partial<PrivateFeed> WithIcon(this Partial<PrivateFeed> it)
            => it.AddFieldName("icon");
        
        public static Partial<PrivateFeed> WithColor(this Partial<PrivateFeed> it)
            => it.AddFieldName("color");
        
        public static Partial<PrivateFeed> WithColor(this Partial<PrivateFeed> it, Func<Partial<PrivateFeedColor>, Partial<PrivateFeedColor>> partialBuilder)
            => it.AddFieldName("color", partialBuilder(new Partial<PrivateFeedColor>(it)));
        
    }
    
}
