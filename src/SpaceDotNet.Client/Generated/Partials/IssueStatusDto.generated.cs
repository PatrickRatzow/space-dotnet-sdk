// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4849551+00:00
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

namespace SpaceDotNet.Client.IssueStatusExtensions
{
    public static class IssueStatusDtoPartialExtensions
    {
        public static Partial<IssueStatusDto> WithId(this Partial<IssueStatusDto> it)
            => it.AddFieldName("id");
        
        public static Partial<IssueStatusDto> WithArchived(this Partial<IssueStatusDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<IssueStatusDto> WithName(this Partial<IssueStatusDto> it)
            => it.AddFieldName("name");
        
        public static Partial<IssueStatusDto> WithResolved(this Partial<IssueStatusDto> it)
            => it.AddFieldName("resolved");
        
        public static Partial<IssueStatusDto> WithColor(this Partial<IssueStatusDto> it)
            => it.AddFieldName("color");
        
    }
    
}
