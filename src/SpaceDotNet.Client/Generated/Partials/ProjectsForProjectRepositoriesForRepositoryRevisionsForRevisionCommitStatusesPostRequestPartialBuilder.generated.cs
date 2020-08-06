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

namespace SpaceDotNet.Client.ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequestPartialBuilder
{
    public static class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithBranch(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("branch");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithChanges(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("changes");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithExecutionStatus(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("executionStatus");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithExecutionStatus(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it, Func<Partial<CommitExecutionStatus>, Partial<CommitExecutionStatus>> partialBuilder)
            => it.AddFieldName("executionStatus", partialBuilder(new Partial<CommitExecutionStatus>(it)));
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithUrl(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("url");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithExternalServiceName(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("externalServiceName");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithTaskName(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("taskName");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithTaskId(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("taskId");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithTimestamp(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("timestamp");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> WithDescription(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCommitStatusesPostRequest> it)
            => it.AddFieldName("description");
        
    }
    
}