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

namespace SpaceDotNet.Client.SprintRecordPartialBuilder
{
    public static class SprintRecordPartialExtensions
    {
        public static Partial<SprintRecord> WithId(this Partial<SprintRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<SprintRecord> WithIsArchived(this Partial<SprintRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<SprintRecord> WithBoard(this Partial<SprintRecord> it)
            => it.AddFieldName("board");
        
        public static Partial<SprintRecord> WithBoard(this Partial<SprintRecord> it, Func<Partial<BoardRecord>, Partial<BoardRecord>> partialBuilder)
            => it.AddFieldName("board", partialBuilder(new Partial<BoardRecord>(it)));
        
        public static Partial<SprintRecord> WithName(this Partial<SprintRecord> it)
            => it.AddFieldName("name");
        
        public static Partial<SprintRecord> WithState(this Partial<SprintRecord> it)
            => it.AddFieldName("state");
        
        public static Partial<SprintRecord> WithState(this Partial<SprintRecord> it, Func<Partial<SprintState>, Partial<SprintState>> partialBuilder)
            => it.AddFieldName("state", partialBuilder(new Partial<SprintState>(it)));
        
        public static Partial<SprintRecord> WithFrom(this Partial<SprintRecord> it)
            => it.AddFieldName("from");
        
        public static Partial<SprintRecord> WithTo(this Partial<SprintRecord> it)
            => it.AddFieldName("to");
        
        public static Partial<SprintRecord> WithIsDefault(this Partial<SprintRecord> it)
            => it.AddFieldName("default");
        
        public static Partial<SprintRecord> WithDescription(this Partial<SprintRecord> it)
            => it.AddFieldName("description");
        
    }
    
}
