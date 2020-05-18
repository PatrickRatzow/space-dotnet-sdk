// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5433189+00:00
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

namespace SpaceDotNet.Client.CreateIssueRequestExtensions
{
    public static class CreateIssueRequestDtoPartialExtensions
    {
        public static Partial<CreateIssueRequestDto> WithTitle(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("title");
        
        public static Partial<CreateIssueRequestDto> WithDescription(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("description");
        
        public static Partial<CreateIssueRequestDto> WithAssignee(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("assignee");
        
        public static Partial<CreateIssueRequestDto> WithStatus(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("status");
        
        public static Partial<CreateIssueRequestDto> WithDueDate(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("dueDate");
        
        public static Partial<CreateIssueRequestDto> WithTags(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("tags");
        
        public static Partial<CreateIssueRequestDto> WithTags(this Partial<CreateIssueRequestDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("tags", partialBuilder(new Partial<string>()));
        
        public static Partial<CreateIssueRequestDto> WithChecklists(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("checklists");
        
        public static Partial<CreateIssueRequestDto> WithChecklists(this Partial<CreateIssueRequestDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("checklists", partialBuilder(new Partial<string>()));
        
        public static Partial<CreateIssueRequestDto> WithAttachments(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("attachments");
        
        public static Partial<CreateIssueRequestDto> WithAttachments(this Partial<CreateIssueRequestDto> it, Func<Partial<AttachmentDto>, Partial<AttachmentDto>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentDto>()));
        
        public static Partial<CreateIssueRequestDto> WithImportInfo(this Partial<CreateIssueRequestDto> it)
            => it.AddFieldName("importInfo");
        
        public static Partial<CreateIssueRequestDto> WithImportInfo(this Partial<CreateIssueRequestDto> it, Func<Partial<ImportedEntityInfoDto>, Partial<ImportedEntityInfoDto>> partialBuilder)
            => it.AddFieldName("importInfo", partialBuilder(new Partial<ImportedEntityInfoDto>()));
        
    }
    
}
