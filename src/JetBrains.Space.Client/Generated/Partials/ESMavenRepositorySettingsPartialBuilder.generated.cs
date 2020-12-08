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

namespace JetBrains.Space.Client.ESMavenRepositorySettingsPartialBuilder
{
    public static class ESMavenRepositorySettingsPartialExtensions
    {
        public static Partial<ESMavenRepositorySettings> WithIsEnableSnapshots(this Partial<ESMavenRepositorySettings> it)
            => it.AddFieldName("enableSnapshots");
        
        public static Partial<ESMavenRepositorySettings> WithRetentionPolicyParams(this Partial<ESMavenRepositorySettings> it)
            => it.AddFieldName("retentionPolicyParams");
        
        public static Partial<ESMavenRepositorySettings> WithRetentionPolicyParams(this Partial<ESMavenRepositorySettings> it, Func<Partial<RetentionPolicyParams>, Partial<RetentionPolicyParams>> partialBuilder)
            => it.AddFieldName("retentionPolicyParams", partialBuilder(new Partial<RetentionPolicyParams>(it)));
        
        public static Partial<ESMavenRepositorySettings> WithIsImmutablePackageVersions(this Partial<ESMavenRepositorySettings> it)
            => it.AddFieldName("immutablePackageVersions");
        
    }
    
}
