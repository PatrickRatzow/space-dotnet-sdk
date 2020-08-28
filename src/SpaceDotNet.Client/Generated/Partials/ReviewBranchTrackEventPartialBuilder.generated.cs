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

namespace SpaceDotNet.Client.ReviewBranchTrackEventPartialBuilder
{
    public static class ReviewBranchTrackEventPartialExtensions
    {
        public static Partial<ReviewBranchTrackEvent> WithRepository(this Partial<ReviewBranchTrackEvent> it)
            => it.AddFieldName("repository");
        
        public static Partial<ReviewBranchTrackEvent> WithBranch(this Partial<ReviewBranchTrackEvent> it)
            => it.AddFieldName("branch");
        
        public static Partial<ReviewBranchTrackEvent> WithIsTrack(this Partial<ReviewBranchTrackEvent> it)
            => it.AddFieldName("track");
        
    }
    
}
