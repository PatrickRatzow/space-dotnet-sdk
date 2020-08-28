// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.TDStatsPartialBuilder
{
    public static class TDStatsPartialExtensions
    {
        public static Partial<TDStats> WithTotalMembers(this Partial<TDStats> it)
            => it.AddFieldName("totalMembers");
        
        public static Partial<TDStats> WithTeams(this Partial<TDStats> it)
            => it.AddFieldName("teams");
        
        public static Partial<TDStats> WithTeams(this Partial<TDStats> it, Func<Partial<Pair<TDTeam, int>>, Partial<Pair<TDTeam, int>>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<Pair<TDTeam, int>>(it)));
        
        public static Partial<TDStats> WithRoles(this Partial<TDStats> it)
            => it.AddFieldName("roles");
        
        public static Partial<TDStats> WithRoles(this Partial<TDStats> it, Func<Partial<Pair<TDRole, int>>, Partial<Pair<TDRole, int>>> partialBuilder)
            => it.AddFieldName("roles", partialBuilder(new Partial<Pair<TDRole, int>>(it)));
        
        public static Partial<TDStats> WithLocations(this Partial<TDStats> it)
            => it.AddFieldName("locations");
        
        public static Partial<TDStats> WithLocations(this Partial<TDStats> it, Func<Partial<Pair<TDLocation, int>>, Partial<Pair<TDLocation, int>>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<Pair<TDLocation, int>>(it)));
        
    }
    
}
