// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4851415+00:00
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

namespace SpaceDotNet.Client.IssueStatusChangedDetailsExtensions
{
    public static class IssueStatusChangedDetailsDtoPartialExtensions
    {
        public static Partial<IssueStatusChangedDetailsDto> WithOldStatus(this Partial<IssueStatusChangedDetailsDto> it)
            => it.AddFieldName("oldStatus");
        
        public static Partial<IssueStatusChangedDetailsDto> WithOldStatus(this Partial<IssueStatusChangedDetailsDto> it, Func<Partial<IssueStatusDto>, Partial<IssueStatusDto>> partialBuilder)
            => it.AddFieldName("oldStatus", partialBuilder(new Partial<IssueStatusDto>()));
        
        public static Partial<IssueStatusChangedDetailsDto> WithNewStatus(this Partial<IssueStatusChangedDetailsDto> it)
            => it.AddFieldName("newStatus");
        
        public static Partial<IssueStatusChangedDetailsDto> WithNewStatus(this Partial<IssueStatusChangedDetailsDto> it, Func<Partial<IssueStatusDto>, Partial<IssueStatusDto>> partialBuilder)
            => it.AddFieldName("newStatus", partialBuilder(new Partial<IssueStatusDto>()));
        
    }
    
}
