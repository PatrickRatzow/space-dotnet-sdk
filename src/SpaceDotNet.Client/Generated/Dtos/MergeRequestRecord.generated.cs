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
    public sealed class MergeRequestRecord
         : CodeReviewRecord, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "MergeRequestRecord";
        
        public MergeRequestRecord() { }
        
        public MergeRequestRecord(ProjectKey project, int number, string title, CodeReviewState state, long createdAt, List<MergeRequestBranchPair> branchPairs, bool? canBeReopened = null, TDMemberProfile? createdBy = null, bool? turnBased = null, M2ChannelRecord? feedChannel = null)
        {
            Project = project;
            Number = number;
            Title = title;
            State = state;
            IsCanBeReopened = canBeReopened;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            IsTurnBased = turnBased;
            FeedChannel = feedChannel;
            BranchPairs = branchPairs;
        }
        
        private PropertyValue<ProjectKey> _project = new PropertyValue<ProjectKey>(nameof(MergeRequestRecord), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectKey Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        private PropertyValue<int> _number = new PropertyValue<int>(nameof(MergeRequestRecord), nameof(Number));
        
        [Required]
        [JsonPropertyName("number")]
        public int Number
        {
            get { return _number.GetValue(); }
            set { _number.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(MergeRequestRecord), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewState> _state = new PropertyValue<CodeReviewState>(nameof(MergeRequestRecord), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public CodeReviewState State
        {
            get { return _state.GetValue(); }
            set { _state.SetValue(value); }
        }
    
        private PropertyValue<bool?> _canBeReopened = new PropertyValue<bool?>(nameof(MergeRequestRecord), nameof(IsCanBeReopened));
        
        [JsonPropertyName("canBeReopened")]
        public bool? IsCanBeReopened
        {
            get { return _canBeReopened.GetValue(); }
            set { _canBeReopened.SetValue(value); }
        }
    
        private PropertyValue<long> _createdAt = new PropertyValue<long>(nameof(MergeRequestRecord), nameof(CreatedAt));
        
        [Required]
        [JsonPropertyName("createdAt")]
        public long CreatedAt
        {
            get { return _createdAt.GetValue(); }
            set { _createdAt.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile?> _createdBy = new PropertyValue<TDMemberProfile?>(nameof(MergeRequestRecord), nameof(CreatedBy));
        
        [JsonPropertyName("createdBy")]
        public TDMemberProfile? CreatedBy
        {
            get { return _createdBy.GetValue(); }
            set { _createdBy.SetValue(value); }
        }
    
        private PropertyValue<bool?> _turnBased = new PropertyValue<bool?>(nameof(MergeRequestRecord), nameof(IsTurnBased));
        
        [JsonPropertyName("turnBased")]
        public bool? IsTurnBased
        {
            get { return _turnBased.GetValue(); }
            set { _turnBased.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecord?> _feedChannel = new PropertyValue<M2ChannelRecord?>(nameof(MergeRequestRecord), nameof(FeedChannel));
        
        [JsonPropertyName("feedChannel")]
        public M2ChannelRecord? FeedChannel
        {
            get { return _feedChannel.GetValue(); }
            set { _feedChannel.SetValue(value); }
        }
    
        private PropertyValue<List<MergeRequestBranchPair>> _branchPairs = new PropertyValue<List<MergeRequestBranchPair>>(nameof(MergeRequestRecord), nameof(BranchPairs));
        
        [Required]
        [JsonPropertyName("branchPairs")]
        public List<MergeRequestBranchPair> BranchPairs
        {
            get { return _branchPairs.GetValue(); }
            set { _branchPairs.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _number.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _state.SetAccessPath(path, validateHasBeenSet);
            _canBeReopened.SetAccessPath(path, validateHasBeenSet);
            _createdAt.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _turnBased.SetAccessPath(path, validateHasBeenSet);
            _feedChannel.SetAccessPath(path, validateHasBeenSet);
            _branchPairs.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
