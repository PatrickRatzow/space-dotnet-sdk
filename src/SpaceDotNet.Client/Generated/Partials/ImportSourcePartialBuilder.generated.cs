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

namespace SpaceDotNet.Client.ImportSourcePartialBuilder
{
    public static class ImportSourcePartialExtensions
    {
        public static Partial<ImportSource> WithId(this Partial<ImportSource> it)
            => it.AddFieldName("id");
        
        public static Partial<ImportSource> WithIsArchived(this Partial<ImportSource> it)
            => it.AddFieldName("archived");
        
        public static Partial<ImportSource> WithImporter(this Partial<ImportSource> it)
            => it.AddFieldName("importer");
        
        public static Partial<ImportSource> WithImporter(this Partial<ImportSource> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("importer", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<ImportSource> WithName(this Partial<ImportSource> it)
            => it.AddFieldName("name");
        
    }
    
}
