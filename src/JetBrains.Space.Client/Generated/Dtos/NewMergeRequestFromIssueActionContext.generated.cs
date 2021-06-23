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
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class NewMergeRequestFromIssueActionContext
         : ClientSideActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "NewMergeRequestFromIssueActionContext";
        
        public NewMergeRequestFromIssueActionContext() { }
        
        public NewMergeRequestFromIssueActionContext(ProjectKey projectKey, string repository, string commitId, int issueNumber, ProjectReposRecord projectRepos, CommitLinksContainer issueCommitsRef)
        {
            ProjectKey = projectKey;
            Repository = repository;
            CommitId = commitId;
            IssueNumber = issueNumber;
            ProjectRepos = projectRepos;
            IssueCommitsRef = issueCommitsRef;
        }
        
        private PropertyValue<ProjectKey> _projectKey = new PropertyValue<ProjectKey>(nameof(NewMergeRequestFromIssueActionContext), nameof(ProjectKey));
        
        [Required]
        [JsonPropertyName("projectKey")]
        public ProjectKey ProjectKey
        {
            get => _projectKey.GetValue();
            set => _projectKey.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(NewMergeRequestFromIssueActionContext), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(NewMergeRequestFromIssueActionContext), nameof(CommitId));
        
        [Required]
        [JsonPropertyName("commitId")]
        public string CommitId
        {
            get => _commitId.GetValue();
            set => _commitId.SetValue(value);
        }
    
        private PropertyValue<int> _issueNumber = new PropertyValue<int>(nameof(NewMergeRequestFromIssueActionContext), nameof(IssueNumber));
        
        [Required]
        [JsonPropertyName("issueNumber")]
        public int IssueNumber
        {
            get => _issueNumber.GetValue();
            set => _issueNumber.SetValue(value);
        }
    
        private PropertyValue<ProjectReposRecord> _projectRepos = new PropertyValue<ProjectReposRecord>(nameof(NewMergeRequestFromIssueActionContext), nameof(ProjectRepos));
        
        [Required]
        [JsonPropertyName("projectRepos")]
        public ProjectReposRecord ProjectRepos
        {
            get => _projectRepos.GetValue();
            set => _projectRepos.SetValue(value);
        }
    
        private PropertyValue<CommitLinksContainer> _issueCommitsRef = new PropertyValue<CommitLinksContainer>(nameof(NewMergeRequestFromIssueActionContext), nameof(IssueCommitsRef));
        
        [Required]
        [JsonPropertyName("issueCommitsRef")]
        public CommitLinksContainer IssueCommitsRef
        {
            get => _issueCommitsRef.GetValue();
            set => _issueCommitsRef.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projectKey.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _commitId.SetAccessPath(path, validateHasBeenSet);
            _issueNumber.SetAccessPath(path, validateHasBeenSet);
            _projectRepos.SetAccessPath(path, validateHasBeenSet);
            _issueCommitsRef.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}