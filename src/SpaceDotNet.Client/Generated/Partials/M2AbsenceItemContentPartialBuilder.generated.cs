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

namespace SpaceDotNet.Client.M2AbsenceItemContentPartialBuilder
{
    public static class M2AbsenceItemContentPartialExtensions
    {
        public static Partial<M2AbsenceItemContent> WithAbsence(this Partial<M2AbsenceItemContent> it)
            => it.AddFieldName("absence");
        
        public static Partial<M2AbsenceItemContent> WithAbsence(this Partial<M2AbsenceItemContent> it, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>> partialBuilder)
            => it.AddFieldName("absence", partialBuilder(new Partial<AbsenceRecord>(it)));
        
        public static Partial<M2AbsenceItemContent> WithBy(this Partial<M2AbsenceItemContent> it)
            => it.AddFieldName("by");
        
        public static Partial<M2AbsenceItemContent> WithBy(this Partial<M2AbsenceItemContent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("by", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
