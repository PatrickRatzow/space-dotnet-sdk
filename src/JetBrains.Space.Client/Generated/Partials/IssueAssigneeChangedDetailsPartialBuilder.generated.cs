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

namespace JetBrains.Space.Client.IssueAssigneeChangedDetailsPartialBuilder
{
    public static class IssueAssigneeChangedDetailsPartialExtensions
    {
        public static Partial<IssueAssigneeChangedDetails> WithOldAssignee(this Partial<IssueAssigneeChangedDetails> it)
            => it.AddFieldName("oldAssignee");
        
        public static Partial<IssueAssigneeChangedDetails> WithOldAssignee(this Partial<IssueAssigneeChangedDetails> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("oldAssignee", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<IssueAssigneeChangedDetails> WithNewAssignee(this Partial<IssueAssigneeChangedDetails> it)
            => it.AddFieldName("newAssignee");
        
        public static Partial<IssueAssigneeChangedDetails> WithNewAssignee(this Partial<IssueAssigneeChangedDetails> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("newAssignee", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
