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

namespace JetBrains.Space.Client.ESSamlAttributeNamesPartialBuilder
{
    public static class ESSamlAttributeNamesPartialExtensions
    {
        public static Partial<ESSamlAttributeNames> WithLoginAttributeName(this Partial<ESSamlAttributeNames> it)
            => it.AddFieldName("loginAttributeName");
        
        public static Partial<ESSamlAttributeNames> WithFirstNameAttributeName(this Partial<ESSamlAttributeNames> it)
            => it.AddFieldName("firstNameAttributeName");
        
        public static Partial<ESSamlAttributeNames> WithLastNameAttributeName(this Partial<ESSamlAttributeNames> it)
            => it.AddFieldName("lastNameAttributeName");
        
        public static Partial<ESSamlAttributeNames> WithFullNameAttributeName(this Partial<ESSamlAttributeNames> it)
            => it.AddFieldName("fullNameAttributeName");
        
        public static Partial<ESSamlAttributeNames> WithEmailAttributeName(this Partial<ESSamlAttributeNames> it)
            => it.AddFieldName("emailAttributeName");
        
        public static Partial<ESSamlAttributeNames> WithIsEmailVerified(this Partial<ESSamlAttributeNames> it)
            => it.AddFieldName("emailVerified");
        
    }
    
}
