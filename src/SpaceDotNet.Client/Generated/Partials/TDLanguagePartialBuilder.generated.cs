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

namespace SpaceDotNet.Client.TDLanguagePartialBuilder
{
    public static class TDLanguagePartialExtensions
    {
        public static Partial<TDLanguage> WithId(this Partial<TDLanguage> it)
            => it.AddFieldName("id");
        
        public static Partial<TDLanguage> WithCode(this Partial<TDLanguage> it)
            => it.AddFieldName("code");
        
        public static Partial<TDLanguage> WithName(this Partial<TDLanguage> it)
            => it.AddFieldName("name");
        
        public static Partial<TDLanguage> WithNativeName(this Partial<TDLanguage> it)
            => it.AddFieldName("nativeName");
        
        public static Partial<TDLanguage> WithFirstNameTitle(this Partial<TDLanguage> it)
            => it.AddFieldName("firstNameTitle");
        
        public static Partial<TDLanguage> WithLastNameTitle(this Partial<TDLanguage> it)
            => it.AddFieldName("lastNameTitle");
        
    }
    
}
