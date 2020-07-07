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

namespace SpaceDotNet.Client.PlanningTagDtoPartialBuilder
{
    public static class PlanningTagDtoPartialExtensions
    {
        public static Partial<PlanningTagDto> WithId(this Partial<PlanningTagDto> it)
            => it.AddFieldName("id");
        
        public static Partial<PlanningTagDto> WithProjectId(this Partial<PlanningTagDto> it)
            => it.AddFieldName("projectId");
        
        public static Partial<PlanningTagDto> WithParent(this Partial<PlanningTagDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<PlanningTagDto> WithParentRecursive(this Partial<PlanningTagDto> it)
            => it.AddFieldName("parent!");
        
        public static Partial<PlanningTagDto> WithParent(this Partial<PlanningTagDto> it, Func<Partial<PlanningTagDto>, Partial<PlanningTagDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<PlanningTagDto>(it)));
        
        public static Partial<PlanningTagDto> WithName(this Partial<PlanningTagDto> it)
            => it.AddFieldName("name");
        
    }
    
}