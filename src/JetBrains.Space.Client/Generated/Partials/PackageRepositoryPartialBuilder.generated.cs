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

namespace JetBrains.Space.Client.PackageRepositoryPartialBuilder
{
    public static class PackageRepositoryPartialExtensions
    {
        public static Partial<PackageRepository> WithId(this Partial<PackageRepository> it)
            => it.AddFieldName("id");
        
        public static Partial<PackageRepository> WithType(this Partial<PackageRepository> it)
            => it.AddFieldName("type");
        
        public static Partial<PackageRepository> WithType(this Partial<PackageRepository> it, Func<Partial<PackageType>, Partial<PackageType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageType>(it)));
        
        public static Partial<PackageRepository> WithName(this Partial<PackageRepository> it)
            => it.AddFieldName("name");
        
        public static Partial<PackageRepository> WithDescription(this Partial<PackageRepository> it)
            => it.AddFieldName("description");
        
        public static Partial<PackageRepository> WithIsPublic(this Partial<PackageRepository> it)
            => it.AddFieldName("public");
        
        public static Partial<PackageRepository> WithSettings(this Partial<PackageRepository> it)
            => it.AddFieldName("settings");
        
        public static Partial<PackageRepository> WithSettings(this Partial<PackageRepository> it, Func<Partial<ESPackageRepositorySettings>, Partial<ESPackageRepositorySettings>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESPackageRepositorySettings>(it)));
        
        public static Partial<PackageRepository> WithMode(this Partial<PackageRepository> it)
            => it.AddFieldName("mode");
        
        public static Partial<PackageRepository> WithMode(this Partial<PackageRepository> it, Func<Partial<PackageRepositoryMode>, Partial<PackageRepositoryMode>> partialBuilder)
            => it.AddFieldName("mode", partialBuilder(new Partial<PackageRepositoryMode>(it)));
        
        public static Partial<PackageRepository> WithIsArchived(this Partial<PackageRepository> it)
            => it.AddFieldName("archived");
        
    }
    
}
