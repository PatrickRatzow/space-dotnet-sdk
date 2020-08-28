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

namespace SpaceDotNet.Client.ProjectsForProjectPlanningIssuesPostRequestPartialBuilder
{
    public static class ProjectsForProjectPlanningIssuesPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithTitle(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("title");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithDescription(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithAssignee(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("assignee");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithAssignee(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it, Func<Partial<ProfileIdentifier>, Partial<ProfileIdentifier>> partialBuilder)
            => it.AddFieldName("assignee", partialBuilder(new Partial<ProfileIdentifier>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithStatus(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("status");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithDueDate(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("dueDate");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithTags(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("tags");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithChecklists(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("checklists");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithSprints(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("sprints");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithAttachments(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("attachments");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithAttachments(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it, Func<Partial<Attachment>, Partial<Attachment>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<Attachment>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithImportInfo(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it)
            => it.AddFieldName("importInfo");
        
        public static Partial<ProjectsForProjectPlanningIssuesPostRequest> WithImportInfo(this Partial<ProjectsForProjectPlanningIssuesPostRequest> it, Func<Partial<ImportedEntityInfo>, Partial<ImportedEntityInfo>> partialBuilder)
            => it.AddFieldName("importInfo", partialBuilder(new Partial<ImportedEntityInfo>(it)));
        
    }
    
}
