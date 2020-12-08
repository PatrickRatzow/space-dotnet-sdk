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

namespace JetBrains.Space.Client
{
    public class ProjectsForProjectRepositoriesForRepositoryCommitSetReviewsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectRepositoriesForRepositoryCommitSetReviewsPostRequest() { }
        
        public ProjectsForProjectRepositoriesForRepositoryCommitSetReviewsPostRequest(List<string> revisions, string? title = null)
        {
            Revisions = revisions;
            Title = title;
        }
        
        private PropertyValue<List<string>> _revisions = new PropertyValue<List<string>>(nameof(ProjectsForProjectRepositoriesForRepositoryCommitSetReviewsPostRequest), nameof(Revisions));
        
        [Required]
        [JsonPropertyName("revisions")]
        public List<string> Revisions
        {
            get => _revisions.GetValue();
            set => _revisions.SetValue(value);
        }
    
        private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(ProjectsForProjectRepositoriesForRepositoryCommitSetReviewsPostRequest), nameof(Title));
        
        [JsonPropertyName("title")]
        public string? Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _revisions.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
