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

namespace SpaceDotNet.Client
{
    public sealed class ReviewRevisionsChangedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ReviewRevisionsChangedEvent";
        
        public ReviewRevisionsChangedEvent() { }
        
        public ReviewRevisionsChangedEvent(List<RepositoryCommitRecord> commits, ReviewRevisionsChangedType changeType, string? projectKey = null, CodeReviewRecord? review = null)
        {
            Commits = commits;
            ChangeType = changeType;
            ProjectKey = projectKey;
            Review = review;
        }
        
        private PropertyValue<List<RepositoryCommitRecord>> _commits = new PropertyValue<List<RepositoryCommitRecord>>(nameof(ReviewRevisionsChangedEvent), nameof(Commits));
        
        [Required]
        [JsonPropertyName("commits")]
        public List<RepositoryCommitRecord> Commits
        {
            get { return _commits.GetValue(); }
            set { _commits.SetValue(value); }
        }
    
        private PropertyValue<ReviewRevisionsChangedType> _changeType = new PropertyValue<ReviewRevisionsChangedType>(nameof(ReviewRevisionsChangedEvent), nameof(ChangeType));
        
        [Required]
        [JsonPropertyName("changeType")]
        public ReviewRevisionsChangedType ChangeType
        {
            get { return _changeType.GetValue(); }
            set { _changeType.SetValue(value); }
        }
    
        private PropertyValue<string?> _projectKey = new PropertyValue<string?>(nameof(ReviewRevisionsChangedEvent), nameof(ProjectKey));
        
        [JsonPropertyName("projectKey")]
        public string? ProjectKey
        {
            get { return _projectKey.GetValue(); }
            set { _projectKey.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewRecord?> _review = new PropertyValue<CodeReviewRecord?>(nameof(ReviewRevisionsChangedEvent), nameof(Review));
        
        [JsonPropertyName("review")]
        public CodeReviewRecord? Review
        {
            get { return _review.GetValue(); }
            set { _review.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _commits.SetAccessPath(path, validateHasBeenSet);
            _changeType.SetAccessPath(path, validateHasBeenSet);
            _projectKey.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
