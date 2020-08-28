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

namespace SpaceDotNet.Client.HAEndpointPartialBuilder
{
    public static class HAEndpointPartialExtensions
    {
        public static Partial<HAEndpoint> WithResource(this Partial<HAEndpoint> it)
            => it.AddFieldName("resource");
        
        public static Partial<HAEndpoint> WithResource(this Partial<HAEndpoint> it, Func<Partial<HAResource>, Partial<HAResource>> partialBuilder)
            => it.AddFieldName("resource", partialBuilder(new Partial<HAResource>(it)));
        
        public static Partial<HAEndpoint> WithMethod(this Partial<HAEndpoint> it)
            => it.AddFieldName("method");
        
        public static Partial<HAEndpoint> WithMethod(this Partial<HAEndpoint> it, Func<Partial<HAMethod>, Partial<HAMethod>> partialBuilder)
            => it.AddFieldName("method", partialBuilder(new Partial<HAMethod>(it)));
        
        public static Partial<HAEndpoint> WithParameters(this Partial<HAEndpoint> it)
            => it.AddFieldName("parameters");
        
        public static Partial<HAEndpoint> WithParameters(this Partial<HAEndpoint> it, Func<Partial<HAParameter>, Partial<HAParameter>> partialBuilder)
            => it.AddFieldName("parameters", partialBuilder(new Partial<HAParameter>(it)));
        
        public static Partial<HAEndpoint> WithRequestBody(this Partial<HAEndpoint> it)
            => it.AddFieldName("requestBody");
        
        public static Partial<HAEndpoint> WithRequestBody(this Partial<HAEndpoint> it, Func<Partial<HATypeObject>, Partial<HATypeObject>> partialBuilder)
            => it.AddFieldName("requestBody", partialBuilder(new Partial<HATypeObject>(it)));
        
        public static Partial<HAEndpoint> WithResponseBody(this Partial<HAEndpoint> it)
            => it.AddFieldName("responseBody");
        
        public static Partial<HAEndpoint> WithResponseBody(this Partial<HAEndpoint> it, Func<Partial<HAType>, Partial<HAType>> partialBuilder)
            => it.AddFieldName("responseBody", partialBuilder(new Partial<HAType>(it)));
        
        public static Partial<HAEndpoint> WithPath(this Partial<HAEndpoint> it)
            => it.AddFieldName("path");
        
        public static Partial<HAEndpoint> WithPath(this Partial<HAEndpoint> it, Func<Partial<HAPath>, Partial<HAPath>> partialBuilder)
            => it.AddFieldName("path", partialBuilder(new Partial<HAPath>(it)));
        
        public static Partial<HAEndpoint> WithDisplayName(this Partial<HAEndpoint> it)
            => it.AddFieldName("displayName");
        
        public static Partial<HAEndpoint> WithDoc(this Partial<HAEndpoint> it)
            => it.AddFieldName("doc");
        
        public static Partial<HAEndpoint> WithDeprecation(this Partial<HAEndpoint> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAEndpoint> WithDeprecation(this Partial<HAEndpoint> it, Func<Partial<HADeprecation>, Partial<HADeprecation>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecation>(it)));
        
    }
    
}
