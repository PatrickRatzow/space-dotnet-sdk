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

namespace SpaceDotNet.Client.ProjectPackageRepositoryPartialBuilder
{
    public static class ProjectPackageRepositoryPartialExtensions
    {
        public static Partial<ProjectPackageRepository> WithId(this Partial<ProjectPackageRepository> it)
            => it.AddFieldName("id");
        
        public static Partial<ProjectPackageRepository> WithProject(this Partial<ProjectPackageRepository> it)
            => it.AddFieldName("project");
        
        public static Partial<ProjectPackageRepository> WithProject(this Partial<ProjectPackageRepository> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<ProjectPackageRepository> WithName(this Partial<ProjectPackageRepository> it)
            => it.AddFieldName("name");
        
        public static Partial<ProjectPackageRepository> WithDescription(this Partial<ProjectPackageRepository> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectPackageRepository> WithRepository(this Partial<ProjectPackageRepository> it)
            => it.AddFieldName("repository");
        
        public static Partial<ProjectPackageRepository> WithRepository(this Partial<ProjectPackageRepository> it, Func<Partial<PackageRepository>, Partial<PackageRepository>> partialBuilder)
            => it.AddFieldName("repository", partialBuilder(new Partial<PackageRepository>(it)));
        
        public static Partial<ProjectPackageRepository> WithIsArchived(this Partial<ProjectPackageRepository> it)
            => it.AddFieldName("archived");
        
    }
    
}
