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

namespace SpaceDotNet.Client.KbProjectContextPartialBuilder
{
    public static class KbProjectContextPartialExtensions
    {
        public static Partial<KbProjectContext> WithProject(this Partial<KbProjectContext> it)
            => it.AddFieldName("project");
        
        public static Partial<KbProjectContext> WithProject(this Partial<KbProjectContext> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
    }
    
}
