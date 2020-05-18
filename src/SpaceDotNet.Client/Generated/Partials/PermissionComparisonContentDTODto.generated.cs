// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5096755+00:00
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

namespace SpaceDotNet.Client.PermissionComparisonContentDTOExtensions
{
    public static class PermissionComparisonContentDTODtoPartialExtensions
    {
        public static Partial<PermissionComparisonContentDTODto> WithEntries(this Partial<PermissionComparisonContentDTODto> it)
            => it.AddFieldName("entries");
        
        public static Partial<PermissionComparisonContentDTODto> WithEntries(this Partial<PermissionComparisonContentDTODto> it, Func<Partial<PermissionComparisonEntryDTODto>, Partial<PermissionComparisonEntryDTODto>> partialBuilder)
            => it.AddFieldName("entries", partialBuilder(new Partial<PermissionComparisonEntryDTODto>()));
        
        public static Partial<PermissionComparisonContentDTODto> WithPrincipals(this Partial<PermissionComparisonContentDTODto> it)
            => it.AddFieldName("principals");
        
        public static Partial<PermissionComparisonContentDTODto> WithPrincipals(this Partial<PermissionComparisonContentDTODto> it, Func<Partial<PermissionSnapshotPrincipalDTODto>, Partial<PermissionSnapshotPrincipalDTODto>> partialBuilder)
            => it.AddFieldName("principals", partialBuilder(new Partial<PermissionSnapshotPrincipalDTODto>()));
        
        public static Partial<PermissionComparisonContentDTODto> WithRights(this Partial<PermissionComparisonContentDTODto> it)
            => it.AddFieldName("rights");
        
        public static Partial<PermissionComparisonContentDTODto> WithRights(this Partial<PermissionComparisonContentDTODto> it, Func<Partial<PermissionSnapshotRightDTODto>, Partial<PermissionSnapshotRightDTODto>> partialBuilder)
            => it.AddFieldName("rights", partialBuilder(new Partial<PermissionSnapshotRightDTODto>()));
        
        public static Partial<PermissionComparisonContentDTODto> WithTargets(this Partial<PermissionComparisonContentDTODto> it)
            => it.AddFieldName("targets");
        
        public static Partial<PermissionComparisonContentDTODto> WithTargets(this Partial<PermissionComparisonContentDTODto> it, Func<Partial<PermissionSnapshotTargetDTODto>, Partial<PermissionSnapshotTargetDTODto>> partialBuilder)
            => it.AddFieldName("targets", partialBuilder(new Partial<PermissionSnapshotTargetDTODto>()));
        
    }
    
}
