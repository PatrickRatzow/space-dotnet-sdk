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

namespace SpaceDotNet.Client.TeamDirectoryLocationsForIdRequestPartialBuilder
{
    public static class TeamDirectoryLocationsForIdRequestPartialExtensions
    {
        public static Partial<TeamDirectoryLocationsForIdRequest> WithName(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithTimezone(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("timezone");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithCustomWorkdays(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("customWorkdays");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithWorkdays(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("workdays");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithPhones(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("phones");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithEmails(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("emails");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithEquipment(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("equipment");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithDescription(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithAddress(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("address");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithType(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("type");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithParentId(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("parentId");
        
        public static Partial<TeamDirectoryLocationsForIdRequest> WithMapId(this Partial<TeamDirectoryLocationsForIdRequest> it)
            => it.AddFieldName("mapId");
        
    }
    
}