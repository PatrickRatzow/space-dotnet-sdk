// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5210342+00:00
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

namespace SpaceDotNet.Client.ReviewCountsExtensions
{
    public static class ReviewCountsDtoPartialExtensions
    {
        public static Partial<ReviewCountsDto> WithOpened(this Partial<ReviewCountsDto> it)
            => it.AddFieldName("opened");
        
        public static Partial<ReviewCountsDto> WithClosed(this Partial<ReviewCountsDto> it)
            => it.AddFieldName("closed");
        
        public static Partial<ReviewCountsDto> WithAuthoredByMe(this Partial<ReviewCountsDto> it)
            => it.AddFieldName("authoredByMe");
        
        public static Partial<ReviewCountsDto> WithReviewedByMe(this Partial<ReviewCountsDto> it)
            => it.AddFieldName("reviewedByMe");
        
        public static Partial<ReviewCountsDto> WithNeedsMyAttention(this Partial<ReviewCountsDto> it)
            => it.AddFieldName("needsMyAttention");
        
        public static Partial<ReviewCountsDto> WithNeedsMyReview(this Partial<ReviewCountsDto> it)
            => it.AddFieldName("needsMyReview");
        
    }
    
}
