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

namespace SpaceDotNet.Client.HAResourcePartialBuilder
{
    public static class HAResourcePartialExtensions
    {
        public static Partial<HAResource> WithId(this Partial<HAResource> it)
            => it.AddFieldName("id");
        
        public static Partial<HAResource> WithPath(this Partial<HAResource> it)
            => it.AddFieldName("path");
        
        public static Partial<HAResource> WithPath(this Partial<HAResource> it, Func<Partial<HAPath>, Partial<HAPath>> partialBuilder)
            => it.AddFieldName("path", partialBuilder(new Partial<HAPath>(it)));
        
        public static Partial<HAResource> WithDisplaySingular(this Partial<HAResource> it)
            => it.AddFieldName("displaySingular");
        
        public static Partial<HAResource> WithDisplayPlural(this Partial<HAResource> it)
            => it.AddFieldName("displayPlural");
        
        public static Partial<HAResource> WithParentResource(this Partial<HAResource> it)
            => it.AddFieldName("parentResource");
        
        public static Partial<HAResource> WithParentResourceRecursive(this Partial<HAResource> it)
            => it.AddFieldName("parentResource!");
        
        public static Partial<HAResource> WithParentResource(this Partial<HAResource> it, Func<Partial<HAResource>, Partial<HAResource>> partialBuilder)
            => it.AddFieldName("parentResource", partialBuilder(new Partial<HAResource>(it)));
        
        public static Partial<HAResource> WithEndpoints(this Partial<HAResource> it)
            => it.AddFieldName("endpoints");
        
        public static Partial<HAResource> WithEndpoints(this Partial<HAResource> it, Func<Partial<HAEndpoint>, Partial<HAEndpoint>> partialBuilder)
            => it.AddFieldName("endpoints", partialBuilder(new Partial<HAEndpoint>(it)));
        
        public static Partial<HAResource> WithNestedResources(this Partial<HAResource> it)
            => it.AddFieldName("nestedResources");
        
        public static Partial<HAResource> WithNestedResourcesRecursive(this Partial<HAResource> it)
            => it.AddFieldName("nestedResources!");
        
        public static Partial<HAResource> WithNestedResources(this Partial<HAResource> it, Func<Partial<HAResource>, Partial<HAResource>> partialBuilder)
            => it.AddFieldName("nestedResources", partialBuilder(new Partial<HAResource>(it)));
        
    }
    
}