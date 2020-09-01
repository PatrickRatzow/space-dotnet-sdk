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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.HATypeObjectPartialBuilder
{
    public static class HATypeObjectPartialExtensions
    {
        public static Partial<HATypeObject> WithFields(this Partial<HATypeObject> it)
            => it.AddFieldName("fields");
        
        public static Partial<HATypeObject> WithFields(this Partial<HATypeObject> it, Func<Partial<HAField>, Partial<HAField>> partialBuilder)
            => it.AddFieldName("fields", partialBuilder(new Partial<HAField>(it)));
        
        public static Partial<HATypeObject> WithKind(this Partial<HATypeObject> it)
            => it.AddFieldName("kind");
        
        public static Partial<HATypeObject> WithKind(this Partial<HATypeObject> it, Func<Partial<HATypeObjectKind>, Partial<HATypeObjectKind>> partialBuilder)
            => it.AddFieldName("kind", partialBuilder(new Partial<HATypeObjectKind>(it)));
        
        public static Partial<HATypeObject> WithIsNullable(this Partial<HATypeObject> it)
            => it.AddFieldName("nullable");
        
    }
    
}