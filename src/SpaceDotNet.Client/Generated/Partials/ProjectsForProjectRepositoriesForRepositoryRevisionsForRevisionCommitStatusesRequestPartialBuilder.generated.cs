// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequestPartialBuilder
{
    public static class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithBranch(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("branch");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithChanges(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("changes");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithExecutionStatus(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("executionStatus");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithExecutionStatus(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it, Func<Partial<CommitExecutionStatus>, Partial<CommitExecutionStatus>> partialBuilder)
            => it.AddFieldName("executionStatus", partialBuilder(new Partial<CommitExecutionStatus>(it)));
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithUrl(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("url");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithExternalServiceName(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("externalServiceName");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithTaskName(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("taskName");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithTaskId(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("taskId");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithTimestamp(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("timestamp");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> WithDescription(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesRequest> it)
            => it.AddFieldName("description");
        
    }
    
}