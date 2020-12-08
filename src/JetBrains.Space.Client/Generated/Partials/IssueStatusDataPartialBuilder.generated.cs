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

namespace JetBrains.Space.Client.IssueStatusDataPartialBuilder
{
    public static class IssueStatusDataPartialExtensions
    {
        public static Partial<IssueStatusData> WithExistingId(this Partial<IssueStatusData> it)
            => it.AddFieldName("existingId");
        
        public static Partial<IssueStatusData> WithName(this Partial<IssueStatusData> it)
            => it.AddFieldName("name");
        
        public static Partial<IssueStatusData> WithIsResolved(this Partial<IssueStatusData> it)
            => it.AddFieldName("resolved");
        
        public static Partial<IssueStatusData> WithColor(this Partial<IssueStatusData> it)
            => it.AddFieldName("color");
        
        public static Partial<IssueStatusData> WithOriginalStatus(this Partial<IssueStatusData> it)
            => it.AddFieldName("originalStatus");
        
        public static Partial<IssueStatusData> WithOriginalStatus(this Partial<IssueStatusData> it, Func<Partial<IssueStatus>, Partial<IssueStatus>> partialBuilder)
            => it.AddFieldName("originalStatus", partialBuilder(new Partial<IssueStatus>(it)));
        
    }
    
}
