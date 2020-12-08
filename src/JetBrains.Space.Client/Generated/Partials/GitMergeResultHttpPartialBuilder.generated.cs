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

namespace JetBrains.Space.Client.GitMergeResultHttpPartialBuilder
{
    public static class GitMergeResultHttpPartialExtensions
    {
        public static Partial<GitMergeResultHttp> WithStatus(this Partial<GitMergeResultHttp> it)
            => it.AddFieldName("status");
        
        public static Partial<GitMergeResultHttp> WithStatus(this Partial<GitMergeResultHttp> it, Func<Partial<GitMergeStatusHttp>, Partial<GitMergeStatusHttp>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<GitMergeStatusHttp>(it)));
        
        public static Partial<GitMergeResultHttp> WithResultCommitId(this Partial<GitMergeResultHttp> it)
            => it.AddFieldName("resultCommitId");
        
    }
    
}
