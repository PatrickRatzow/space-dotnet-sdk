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

namespace JetBrains.Space.Client.ReviewRevisionsChangedEventPartialBuilder
{
    public static class ReviewRevisionsChangedEventPartialExtensions
    {
        public static Partial<ReviewRevisionsChangedEvent> WithCommits(this Partial<ReviewRevisionsChangedEvent> it)
            => it.AddFieldName("commits");
        
        public static Partial<ReviewRevisionsChangedEvent> WithCommits(this Partial<ReviewRevisionsChangedEvent> it, Func<Partial<RepositoryCommitRecord>, Partial<RepositoryCommitRecord>> partialBuilder)
            => it.AddFieldName("commits", partialBuilder(new Partial<RepositoryCommitRecord>(it)));
        
        public static Partial<ReviewRevisionsChangedEvent> WithChangeType(this Partial<ReviewRevisionsChangedEvent> it)
            => it.AddFieldName("changeType");
        
        public static Partial<ReviewRevisionsChangedEvent> WithChangeType(this Partial<ReviewRevisionsChangedEvent> it, Func<Partial<ReviewRevisionsChangedType>, Partial<ReviewRevisionsChangedType>> partialBuilder)
            => it.AddFieldName("changeType", partialBuilder(new Partial<ReviewRevisionsChangedType>(it)));
        
        public static Partial<ReviewRevisionsChangedEvent> WithProjectKey(this Partial<ReviewRevisionsChangedEvent> it)
            => it.AddFieldName("projectKey");
        
        public static Partial<ReviewRevisionsChangedEvent> WithReview(this Partial<ReviewRevisionsChangedEvent> it)
            => it.AddFieldName("review");
        
        public static Partial<ReviewRevisionsChangedEvent> WithReview(this Partial<ReviewRevisionsChangedEvent> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
    }
    
}
