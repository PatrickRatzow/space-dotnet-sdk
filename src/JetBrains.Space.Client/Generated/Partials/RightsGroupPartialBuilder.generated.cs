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

namespace JetBrains.Space.Client.RightsGroupPartialBuilder
{
    public static class RightsGroupPartialExtensions
    {
        public static Partial<RightsGroup> WithTitle(this Partial<RightsGroup> it)
            => it.AddFieldName("title");
        
        public static Partial<RightsGroup> WithPriority(this Partial<RightsGroup> it)
            => it.AddFieldName("priority");
        
        public static Partial<RightsGroup> WithRights(this Partial<RightsGroup> it)
            => it.AddFieldName("rights");
        
        public static Partial<RightsGroup> WithRights(this Partial<RightsGroup> it, Func<Partial<Right>, Partial<Right>> partialBuilder)
            => it.AddFieldName("rights", partialBuilder(new Partial<Right>(it)));
        
    }
    
}
