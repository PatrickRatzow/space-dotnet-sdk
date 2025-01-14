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

namespace JetBrains.Space.Client.ESAuthModulePartialBuilder
{
    public static class ESAuthModulePartialExtensions
    {
        public static Partial<ESAuthModule> WithId(this Partial<ESAuthModule> it)
            => it.AddFieldName("id");
        
        public static Partial<ESAuthModule> WithKey(this Partial<ESAuthModule> it)
            => it.AddFieldName("key");
        
        public static Partial<ESAuthModule> WithName(this Partial<ESAuthModule> it)
            => it.AddFieldName("name");
        
        public static Partial<ESAuthModule> WithOrdinal(this Partial<ESAuthModule> it)
            => it.AddFieldName("ordinal");
        
        public static Partial<ESAuthModule> WithIsEnabled(this Partial<ESAuthModule> it)
            => it.AddFieldName("enabled");
        
        public static Partial<ESAuthModule> WithIconDataURI(this Partial<ESAuthModule> it)
            => it.AddFieldName("iconDataURI");
        
        public static Partial<ESAuthModule> WithSettings(this Partial<ESAuthModule> it)
            => it.AddFieldName("settings");
        
        public static Partial<ESAuthModule> WithSettings(this Partial<ESAuthModule> it, Func<Partial<ESAuthModuleSettings>, Partial<ESAuthModuleSettings>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettings>(it)));
        
    }
    
}
