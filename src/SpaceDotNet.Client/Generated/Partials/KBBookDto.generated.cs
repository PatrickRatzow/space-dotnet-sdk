// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4863401+00:00
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

namespace SpaceDotNet.Client.KBBookExtensions
{
    public static class KBBookDtoPartialExtensions
    {
        public static Partial<KBBookDto> WithId(this Partial<KBBookDto> it)
            => it.AddFieldName("id");
        
        public static Partial<KBBookDto> WithArchived(this Partial<KBBookDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<KBBookDto> WithName(this Partial<KBBookDto> it)
            => it.AddFieldName("name");
        
        public static Partial<KBBookDto> WithSummary(this Partial<KBBookDto> it)
            => it.AddFieldName("summary");
        
        public static Partial<KBBookDto> WithUpdated(this Partial<KBBookDto> it)
            => it.AddFieldName("updated");
        
        public static Partial<KBBookDto> WithAlias(this Partial<KBBookDto> it)
            => it.AddFieldName("alias");
        
        public static Partial<KBBookDto> WithLocations(this Partial<KBBookDto> it)
            => it.AddFieldName("locations");
        
        public static Partial<KBBookDto> WithLocations(this Partial<KBBookDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocationDto>()));
        
        public static Partial<KBBookDto> WithTeams(this Partial<KBBookDto> it)
            => it.AddFieldName("teams");
        
        public static Partial<KBBookDto> WithTeams(this Partial<KBBookDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<KBBookDto> WithRootFolder(this Partial<KBBookDto> it)
            => it.AddFieldName("rootFolder");
        
        public static Partial<KBBookDto> WithRootFolder(this Partial<KBBookDto> it, Func<Partial<KBFolderDto>, Partial<KBFolderDto>> partialBuilder)
            => it.AddFieldName("rootFolder", partialBuilder(new Partial<KBFolderDto>()));
        
    }
    
}
