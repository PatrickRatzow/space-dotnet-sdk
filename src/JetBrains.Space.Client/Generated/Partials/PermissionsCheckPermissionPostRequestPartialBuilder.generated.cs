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

namespace JetBrains.Space.Client.PermissionsCheckPermissionPostRequestPartialBuilder
{
    public static class PermissionsCheckPermissionPostRequestPartialExtensions
    {
        public static Partial<PermissionsCheckPermissionPostRequest> WithPrincipal(this Partial<PermissionsCheckPermissionPostRequest> it)
            => it.AddFieldName("principal");
        
        public static Partial<PermissionsCheckPermissionPostRequest> WithPrincipal(this Partial<PermissionsCheckPermissionPostRequest> it, Func<Partial<PrincipalIn>, Partial<PrincipalIn>> partialBuilder)
            => it.AddFieldName("principal", partialBuilder(new Partial<PrincipalIn>(it)));
        
        public static Partial<PermissionsCheckPermissionPostRequest> WithUniqueRightCode(this Partial<PermissionsCheckPermissionPostRequest> it)
            => it.AddFieldName("uniqueRightCode");
        
        public static Partial<PermissionsCheckPermissionPostRequest> WithTarget(this Partial<PermissionsCheckPermissionPostRequest> it)
            => it.AddFieldName("target");
        
        public static Partial<PermissionsCheckPermissionPostRequest> WithTarget(this Partial<PermissionsCheckPermissionPostRequest> it, Func<Partial<PermissionTarget>, Partial<PermissionTarget>> partialBuilder)
            => it.AddFieldName("target", partialBuilder(new Partial<PermissionTarget>(it)));
        
    }
    
}
