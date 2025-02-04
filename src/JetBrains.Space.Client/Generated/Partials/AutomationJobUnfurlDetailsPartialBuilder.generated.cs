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

namespace JetBrains.Space.Client.AutomationJobUnfurlDetailsPartialBuilder
{
    public static class AutomationJobUnfurlDetailsPartialExtensions
    {
        public static Partial<AutomationJobUnfurlDetails> WithJobId(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobId");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobName(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobName");
        
        public static Partial<AutomationJobUnfurlDetails> WithProjectRef(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("projectRef");
        
        public static Partial<AutomationJobUnfurlDetails> WithProjectRef(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("projectRef", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<AutomationJobUnfurlDetails> WithRepoName(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("repoName");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobExecutionDisplayStatusFilter(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobExecutionDisplayStatusFilter");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobExecutionDisplayStatusFilter(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<JobExecutionDisplayStatus>, Partial<JobExecutionDisplayStatus>> partialBuilder)
            => it.AddFieldName("jobExecutionDisplayStatusFilter", partialBuilder(new Partial<JobExecutionDisplayStatus>(it)));
        
        public static Partial<AutomationJobUnfurlDetails> WithJobTriggerFilter(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobTriggerFilter");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobTriggerFilter(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<JobTriggerType>, Partial<JobTriggerType>> partialBuilder)
            => it.AddFieldName("jobTriggerFilter", partialBuilder(new Partial<JobTriggerType>(it)));
        
        public static Partial<AutomationJobUnfurlDetails> WithBranch(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("branch");
        
        public static Partial<AutomationJobUnfurlDetails> WithBranch(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<Branch>, Partial<Branch>> partialBuilder)
            => it.AddFieldName("branch", partialBuilder(new Partial<Branch>(it)));
        
    }
    
}
