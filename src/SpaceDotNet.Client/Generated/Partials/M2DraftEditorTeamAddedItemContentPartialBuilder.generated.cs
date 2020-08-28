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

namespace SpaceDotNet.Client.M2DraftEditorTeamAddedItemContentPartialBuilder
{
    public static class M2DraftEditorTeamAddedItemContentPartialExtensions
    {
        public static Partial<M2DraftEditorTeamAddedItemContent> WithId(this Partial<M2DraftEditorTeamAddedItemContent> it)
            => it.AddFieldName("id");
        
        public static Partial<M2DraftEditorTeamAddedItemContent> WithTeam(this Partial<M2DraftEditorTeamAddedItemContent> it)
            => it.AddFieldName("team");
        
        public static Partial<M2DraftEditorTeamAddedItemContent> WithTeam(this Partial<M2DraftEditorTeamAddedItemContent> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<M2DraftEditorTeamAddedItemContent> WithTitle(this Partial<M2DraftEditorTeamAddedItemContent> it)
            => it.AddFieldName("title");
        
    }
    
}
