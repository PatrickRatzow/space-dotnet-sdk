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

namespace SpaceDotNet.Client.PlanningTagPartialBuilder
{
    public static class PlanningTagPartialExtensions
    {
        public static Partial<PlanningTag> WithId(this Partial<PlanningTag> it)
            => it.AddFieldName("id");
        
        public static Partial<PlanningTag> WithProjectId(this Partial<PlanningTag> it)
            => it.AddFieldName("projectId");
        
        public static Partial<PlanningTag> WithParent(this Partial<PlanningTag> it)
            => it.AddFieldName("parent");
        
        public static Partial<PlanningTag> WithParentRecursive(this Partial<PlanningTag> it)
            => it.AddFieldName("parent!");
        
        public static Partial<PlanningTag> WithParent(this Partial<PlanningTag> it, Func<Partial<PlanningTag>, Partial<PlanningTag>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<PlanningTag>(it)));
        
        public static Partial<PlanningTag> WithName(this Partial<PlanningTag> it)
            => it.AddFieldName("name");
        
    }
    
}
