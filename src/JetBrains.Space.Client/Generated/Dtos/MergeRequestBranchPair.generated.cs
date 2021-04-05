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
    public sealed class MergeRequestBranchPair
         : IPropagatePropertyAccessPath
    {
        public MergeRequestBranchPair() { }
        
        public MergeRequestBranchPair(string repository, string sourceBranch, string targetBranch, string sourceBranchRef, MergeRequestBranch? sourceBranchInfo = null, MergeRequestBranch? targetBranchInfo = null, bool? isMerged = null)
        {
            Repository = repository;
            SourceBranch = sourceBranch;
            TargetBranch = targetBranch;
            SourceBranchRef = sourceBranchRef;
            SourceBranchInfo = sourceBranchInfo;
            TargetBranchInfo = targetBranchInfo;
            IsMerged = isMerged;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(SourceBranch));
        
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch
        {
            get => _sourceBranch.GetValue();
            set => _sourceBranch.SetValue(value);
        }
    
        private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(TargetBranch));
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch
        {
            get => _targetBranch.GetValue();
            set => _targetBranch.SetValue(value);
        }
    
        private PropertyValue<string> _sourceBranchRef = new PropertyValue<string>(nameof(MergeRequestBranchPair), nameof(SourceBranchRef));
        
        [Required]
        [JsonPropertyName("sourceBranchRef")]
        public string SourceBranchRef
        {
            get => _sourceBranchRef.GetValue();
            set => _sourceBranchRef.SetValue(value);
        }
    
        private PropertyValue<MergeRequestBranch?> _sourceBranchInfo = new PropertyValue<MergeRequestBranch?>(nameof(MergeRequestBranchPair), nameof(SourceBranchInfo));
        
        [JsonPropertyName("sourceBranchInfo")]
        public MergeRequestBranch? SourceBranchInfo
        {
            get => _sourceBranchInfo.GetValue();
            set => _sourceBranchInfo.SetValue(value);
        }
    
        private PropertyValue<MergeRequestBranch?> _targetBranchInfo = new PropertyValue<MergeRequestBranch?>(nameof(MergeRequestBranchPair), nameof(TargetBranchInfo));
        
        [JsonPropertyName("targetBranchInfo")]
        public MergeRequestBranch? TargetBranchInfo
        {
            get => _targetBranchInfo.GetValue();
            set => _targetBranchInfo.SetValue(value);
        }
    
        private PropertyValue<bool?> _isMerged = new PropertyValue<bool?>(nameof(MergeRequestBranchPair), nameof(IsMerged));
        
        [JsonPropertyName("isMerged")]
        public bool? IsMerged
        {
            get => _isMerged.GetValue();
            set => _isMerged.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _sourceBranch.SetAccessPath(path, validateHasBeenSet);
            _targetBranch.SetAccessPath(path, validateHasBeenSet);
            _sourceBranchRef.SetAccessPath(path, validateHasBeenSet);
            _sourceBranchInfo.SetAccessPath(path, validateHasBeenSet);
            _targetBranchInfo.SetAccessPath(path, validateHasBeenSet);
            _isMerged.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
