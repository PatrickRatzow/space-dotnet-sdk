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
    public sealed class ReviewCounts
         : IPropagatePropertyAccessPath
    {
        public ReviewCounts() { }
        
        public ReviewCounts(int opened, int closed, int authoredByMe, int reviewedByMe, int needsMyAttention, int needsMyReview)
        {
            Opened = opened;
            Closed = closed;
            AuthoredByMe = authoredByMe;
            ReviewedByMe = reviewedByMe;
            NeedsMyAttention = needsMyAttention;
            NeedsMyReview = needsMyReview;
        }
        
        private PropertyValue<int> _opened = new PropertyValue<int>(nameof(ReviewCounts), nameof(Opened));
        
        [Required]
        [JsonPropertyName("opened")]
        public int Opened
        {
            get { return _opened.GetValue(); }
            set { _opened.SetValue(value); }
        }
    
        private PropertyValue<int> _closed = new PropertyValue<int>(nameof(ReviewCounts), nameof(Closed));
        
        [Required]
        [JsonPropertyName("closed")]
        public int Closed
        {
            get { return _closed.GetValue(); }
            set { _closed.SetValue(value); }
        }
    
        private PropertyValue<int> _authoredByMe = new PropertyValue<int>(nameof(ReviewCounts), nameof(AuthoredByMe));
        
        [Required]
        [JsonPropertyName("authoredByMe")]
        public int AuthoredByMe
        {
            get { return _authoredByMe.GetValue(); }
            set { _authoredByMe.SetValue(value); }
        }
    
        private PropertyValue<int> _reviewedByMe = new PropertyValue<int>(nameof(ReviewCounts), nameof(ReviewedByMe));
        
        [Required]
        [JsonPropertyName("reviewedByMe")]
        public int ReviewedByMe
        {
            get { return _reviewedByMe.GetValue(); }
            set { _reviewedByMe.SetValue(value); }
        }
    
        private PropertyValue<int> _needsMyAttention = new PropertyValue<int>(nameof(ReviewCounts), nameof(NeedsMyAttention));
        
        [Required]
        [JsonPropertyName("needsMyAttention")]
        public int NeedsMyAttention
        {
            get { return _needsMyAttention.GetValue(); }
            set { _needsMyAttention.SetValue(value); }
        }
    
        private PropertyValue<int> _needsMyReview = new PropertyValue<int>(nameof(ReviewCounts), nameof(NeedsMyReview));
        
        [Required]
        [JsonPropertyName("needsMyReview")]
        public int NeedsMyReview
        {
            get { return _needsMyReview.GetValue(); }
            set { _needsMyReview.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _opened.SetAccessPath(path, validateHasBeenSet);
            _closed.SetAccessPath(path, validateHasBeenSet);
            _authoredByMe.SetAccessPath(path, validateHasBeenSet);
            _reviewedByMe.SetAccessPath(path, validateHasBeenSet);
            _needsMyAttention.SetAccessPath(path, validateHasBeenSet);
            _needsMyReview.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
