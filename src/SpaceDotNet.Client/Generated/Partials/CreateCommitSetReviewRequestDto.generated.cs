// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5419502+00:00
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

namespace SpaceDotNet.Client.CreateCommitSetReviewRequestExtensions
{
    public static class CreateCommitSetReviewRequestDtoPartialExtensions
    {
        public static Partial<CreateCommitSetReviewRequestDto> WithRevisions(this Partial<CreateCommitSetReviewRequestDto> it)
            => it.AddFieldName("revisions");
        
        public static Partial<CreateCommitSetReviewRequestDto> WithRevisions(this Partial<CreateCommitSetReviewRequestDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("revisions", partialBuilder(new Partial<string>()));
        
        public static Partial<CreateCommitSetReviewRequestDto> WithTitle(this Partial<CreateCommitSetReviewRequestDto> it)
            => it.AddFieldName("title");
        
    }
    
}
