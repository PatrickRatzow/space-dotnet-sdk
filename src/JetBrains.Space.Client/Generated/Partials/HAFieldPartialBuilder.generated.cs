// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.HAFieldPartialBuilder
{
    public static class HAFieldPartialExtensions
    {
        public static Partial<HAField> WithName(this Partial<HAField> it)
            => it.AddFieldName("name");
        
        public static Partial<HAField> WithType(this Partial<HAField> it)
            => it.AddFieldName("type");
        
        public static Partial<HAField> WithType(this Partial<HAField> it, Func<Partial<HAType>, Partial<HAType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<HAType>(it)));
        
        public static Partial<HAField> WithDefaultValue(this Partial<HAField> it)
            => it.AddFieldName("defaultValue");
        
        public static Partial<HAField> WithDefaultValue(this Partial<HAField> it, Func<Partial<HADefaultValue>, Partial<HADefaultValue>> partialBuilder)
            => it.AddFieldName("defaultValue", partialBuilder(new Partial<HADefaultValue>(it)));
        
        public static Partial<HAField> WithIsOptional(this Partial<HAField> it)
            => it.AddFieldName("optional");
        
        public static Partial<HAField> WithDeprecation(this Partial<HAField> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAField> WithDeprecation(this Partial<HAField> it, Func<Partial<HADeprecation>, Partial<HADeprecation>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecation>(it)));
        
    }
    
}
