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

namespace SpaceDotNet.Client.TeamDirectoryLocationMapMemberPointsRequestPartialBuilder
{
    public static class TeamDirectoryLocationMapMemberPointsRequestPartialExtensions
    {
        public static Partial<TeamDirectoryLocationMapMemberPointsRequest> WithMemberLocationId(this Partial<TeamDirectoryLocationMapMemberPointsRequest> it)
            => it.AddFieldName("memberLocationId");
        
        public static Partial<TeamDirectoryLocationMapMemberPointsRequest> WithX(this Partial<TeamDirectoryLocationMapMemberPointsRequest> it)
            => it.AddFieldName("x");
        
        public static Partial<TeamDirectoryLocationMapMemberPointsRequest> WithY(this Partial<TeamDirectoryLocationMapMemberPointsRequest> it)
            => it.AddFieldName("y");
        
        public static Partial<TeamDirectoryLocationMapMemberPointsRequest> WithMapId(this Partial<TeamDirectoryLocationMapMemberPointsRequest> it)
            => it.AddFieldName("mapId");
        
    }
    
}