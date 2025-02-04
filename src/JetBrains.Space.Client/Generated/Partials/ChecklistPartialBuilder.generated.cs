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

namespace JetBrains.Space.Client.ChecklistPartialBuilder
{
    public static class ChecklistPartialExtensions
    {
        public static Partial<Checklist> WithId(this Partial<Checklist> it)
            => it.AddFieldName("id");
        
        public static Partial<Checklist> WithIsArchived(this Partial<Checklist> it)
            => it.AddFieldName("archived");
        
        public static Partial<Checklist> WithProjectId(this Partial<Checklist> it)
            => it.AddFieldName("projectId");
        
        public static Partial<Checklist> WithProject(this Partial<Checklist> it)
            => it.AddFieldName("project");
        
        public static Partial<Checklist> WithProject(this Partial<Checklist> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<Checklist> WithOwner(this Partial<Checklist> it)
            => it.AddFieldName("owner");
        
        public static Partial<Checklist> WithOwner(this Partial<Checklist> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<Checklist> WithName(this Partial<Checklist> it)
            => it.AddFieldName("name");
        
        public static Partial<Checklist> WithRoot(this Partial<Checklist> it)
            => it.AddFieldName("root");
        
        public static Partial<Checklist> WithRoot(this Partial<Checklist> it, Func<Partial<PlanItem>, Partial<PlanItem>> partialBuilder)
            => it.AddFieldName("root", partialBuilder(new Partial<PlanItem>(it)));
        
        public static Partial<Checklist> WithRootTag(this Partial<Checklist> it)
            => it.AddFieldName("rootTag");
        
        public static Partial<Checklist> WithRootTag(this Partial<Checklist> it, Func<Partial<PlanningTag>, Partial<PlanningTag>> partialBuilder)
            => it.AddFieldName("rootTag", partialBuilder(new Partial<PlanningTag>(it)));
        
        public static Partial<Checklist> WithDescription(this Partial<Checklist> it)
            => it.AddFieldName("description");
        
        public static Partial<Checklist> WithTotalItemsCount(this Partial<Checklist> it)
            => it.AddFieldName("totalItemsCount");
        
        public static Partial<Checklist> WithDoneItemsCount(this Partial<Checklist> it)
            => it.AddFieldName("doneItemsCount");
        
        public static Partial<Checklist> WithUpdatedTime(this Partial<Checklist> it)
            => it.AddFieldName("updatedTime");
        
    }
    
}
