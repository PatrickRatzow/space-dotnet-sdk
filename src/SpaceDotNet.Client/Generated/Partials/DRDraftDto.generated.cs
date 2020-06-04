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

namespace SpaceDotNet.Client.DRDraftExtensions
{
    public static class DRDraftDtoPartialExtensions
    {
        public static Partial<DRDraftDto> WithId(this Partial<DRDraftDto> it)
            => it.AddFieldName("id");
        
        public static Partial<DRDraftDto> WithTitle(this Partial<DRDraftDto> it)
            => it.AddFieldName("title");
        
        public static Partial<DRDraftDto> WithText(this Partial<DRDraftDto> it)
            => it.AddFieldName("text");
        
        public static Partial<DRDraftDto> WithType(this Partial<DRDraftDto> it)
            => it.AddFieldName("type");
        
        public static Partial<DRDraftDto> WithType(this Partial<DRDraftDto> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DraftDocumentType>()));
        
        public static Partial<DRDraftDto> WithModified(this Partial<DRDraftDto> it)
            => it.AddFieldName("modified");
        
        public static Partial<DRDraftDto> WithPublishedFlag(this Partial<DRDraftDto> it)
            => it.AddFieldName("publishedFlag");
        
        public static Partial<DRDraftDto> WithShared(this Partial<DRDraftDto> it)
            => it.AddFieldName("shared");
        
        public static Partial<DRDraftDto> WithAccessOrdinal(this Partial<DRDraftDto> it)
            => it.AddFieldName("accessOrdinal");
        
        public static Partial<DRDraftDto> WithPublicationDetails(this Partial<DRDraftDto> it)
            => it.AddFieldName("publicationDetails");
        
        public static Partial<DRDraftDto> WithPublicationDetails(this Partial<DRDraftDto> it, Func<Partial<DraftPublicationDetailsDto>, Partial<DraftPublicationDetailsDto>> partialBuilder)
            => it.AddFieldName("publicationDetails", partialBuilder(new Partial<DraftPublicationDetailsDto>()));
        
        public static Partial<DRDraftDto> WithAuthor(this Partial<DRDraftDto> it)
            => it.AddFieldName("author");
        
        public static Partial<DRDraftDto> WithAuthor(this Partial<DRDraftDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<DRDraftDto> WithEditors(this Partial<DRDraftDto> it)
            => it.AddFieldName("editors");
        
        public static Partial<DRDraftDto> WithEditors(this Partial<DRDraftDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("editors", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<DRDraftDto> WithEditorsTeams(this Partial<DRDraftDto> it)
            => it.AddFieldName("editorsTeams");
        
        public static Partial<DRDraftDto> WithEditorsTeams(this Partial<DRDraftDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("editorsTeams", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<DRDraftDto> WithVersion(this Partial<DRDraftDto> it)
            => it.AddFieldName("version");
        
        public static Partial<DRDraftDto> WithDocument(this Partial<DRDraftDto> it)
            => it.AddFieldName("document");
        
        public static Partial<DRDraftDto> WithDocument(this Partial<DRDraftDto> it, Func<Partial<TextDocumentDto>, Partial<TextDocumentDto>> partialBuilder)
            => it.AddFieldName("document", partialBuilder(new Partial<TextDocumentDto>()));
        
    }
    
}
