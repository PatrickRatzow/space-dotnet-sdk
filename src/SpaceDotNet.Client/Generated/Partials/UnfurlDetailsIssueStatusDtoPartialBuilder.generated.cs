// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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

namespace SpaceDotNet.Client.UnfurlDetailsIssueStatusDtoPartialBuilder
{
    public static class UnfurlDetailsIssueStatusDtoPartialExtensions
    {
        public static Partial<UnfurlDetailsIssueStatusDto> WithStatus(this Partial<UnfurlDetailsIssueStatusDto> it)
            => it.AddFieldName("status");
        
        public static Partial<UnfurlDetailsIssueStatusDto> WithStatus(this Partial<UnfurlDetailsIssueStatusDto> it, Func<Partial<IssueStatusDto>, Partial<IssueStatusDto>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<IssueStatusDto>(it)));
        
    }
    
}
