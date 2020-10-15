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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest() { }
        
        public ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest(CommitExecutionStatus executionStatus, string url, string externalServiceName, string taskName, string taskId, string? branch = null, List<string>? changes = null, long? timestamp = null, string? description = null)
        {
            Branch = branch;
            Changes = changes;
            ExecutionStatus = executionStatus;
            Url = url;
            ExternalServiceName = externalServiceName;
            TaskName = taskName;
            TaskId = taskId;
            Timestamp = timestamp;
            Description = description;
        }
        
        private PropertyValue<string?> _branch = new PropertyValue<string?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(Branch));
        
        [JsonPropertyName("branch")]
        public string? Branch
        {
            get { return _branch.GetValue(); }
            set { _branch.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _changes = new PropertyValue<List<string>?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(Changes));
        
        [JsonPropertyName("changes")]
        public List<string>? Changes
        {
            get { return _changes.GetValue(); }
            set { _changes.SetValue(value); }
        }
    
        private PropertyValue<CommitExecutionStatus> _executionStatus = new PropertyValue<CommitExecutionStatus>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(ExecutionStatus));
        
        [Required]
        [JsonPropertyName("executionStatus")]
        public CommitExecutionStatus ExecutionStatus
        {
            get { return _executionStatus.GetValue(); }
            set { _executionStatus.SetValue(value); }
        }
    
        private PropertyValue<string> _url = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(Url));
        
        [Required]
        [JsonPropertyName("url")]
        public string Url
        {
            get { return _url.GetValue(); }
            set { _url.SetValue(value); }
        }
    
        private PropertyValue<string> _externalServiceName = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(ExternalServiceName));
        
        [Required]
        [JsonPropertyName("externalServiceName")]
        public string ExternalServiceName
        {
            get { return _externalServiceName.GetValue(); }
            set { _externalServiceName.SetValue(value); }
        }
    
        private PropertyValue<string> _taskName = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(TaskName));
        
        [Required]
        [JsonPropertyName("taskName")]
        public string TaskName
        {
            get { return _taskName.GetValue(); }
            set { _taskName.SetValue(value); }
        }
    
        private PropertyValue<string> _taskId = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(TaskId));
        
        [Required]
        [JsonPropertyName("taskId")]
        public string TaskId
        {
            get { return _taskId.GetValue(); }
            set { _taskId.SetValue(value); }
        }
    
        private PropertyValue<long?> _timestamp = new PropertyValue<long?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(Timestamp));
        
        [JsonPropertyName("timestamp")]
        public long? Timestamp
        {
            get { return _timestamp.GetValue(); }
            set { _timestamp.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _branch.SetAccessPath(path, validateHasBeenSet);
            _changes.SetAccessPath(path, validateHasBeenSet);
            _executionStatus.SetAccessPath(path, validateHasBeenSet);
            _url.SetAccessPath(path, validateHasBeenSet);
            _externalServiceName.SetAccessPath(path, validateHasBeenSet);
            _taskName.SetAccessPath(path, validateHasBeenSet);
            _taskId.SetAccessPath(path, validateHasBeenSet);
            _timestamp.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}