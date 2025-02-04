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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ContainerImageConfigPartialBuilder
{
    public static class ContainerImageConfigPartialExtensions
    {
        public static Partial<ContainerImageConfig> WithUserName(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("userName");
        
        public static Partial<ContainerImageConfig> WithPorts(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("ports");
        
        public static Partial<ContainerImageConfig> WithVolumes(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("volumes");
        
        public static Partial<ContainerImageConfig> WithEnv(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("env");
        
        public static Partial<ContainerImageConfig> WithWorkingDir(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("workingDir");
        
        public static Partial<ContainerImageConfig> WithEntryPoint(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("entryPoint");
        
        public static Partial<ContainerImageConfig> WithCmd(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("cmd");
        
        public static Partial<ContainerImageConfig> WithLabels(this Partial<ContainerImageConfig> it)
            => it.AddFieldName("labels");
        
    }
    
}
