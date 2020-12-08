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

namespace JetBrains.Space.Client.ReviewerParamPartialBuilder
{
    public static class ReviewerParamPartialExtensions
    {
        public static Partial<ReviewerParam> WithProfileId(this Partial<ReviewerParam> it)
            => it.AddFieldName("profileId");
        
        public static Partial<ReviewerParam> WithQualityGateSlot(this Partial<ReviewerParam> it)
            => it.AddFieldName("qualityGateSlot");
        
        public static Partial<ReviewerParam> WithQualityGateSlot(this Partial<ReviewerParam> it, Func<Partial<CodeReviewParticipantQualityGateSlot>, Partial<CodeReviewParticipantQualityGateSlot>> partialBuilder)
            => it.AddFieldName("qualityGateSlot", partialBuilder(new Partial<CodeReviewParticipantQualityGateSlot>(it)));
        
    }
    
}
