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

namespace JetBrains.Space.Client.ProjectsForProjectPlanningIssuesForIssueIdPatchRequestPartialBuilder
{
    public static class ProjectsForProjectPlanningIssuesForIssueIdPatchRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> WithTitle(this Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> it)
            => it.AddFieldName("title");
        
        public static Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> WithDescription(this Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> WithAssignee(this Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> it)
            => it.AddFieldName("assignee");
        
        public static Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> WithStatus(this Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> it)
            => it.AddFieldName("status");
        
        public static Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> WithDueDate(this Partial<ProjectsForProjectPlanningIssuesForIssueIdPatchRequest> it)
            => it.AddFieldName("dueDate");
        
    }
    
}
