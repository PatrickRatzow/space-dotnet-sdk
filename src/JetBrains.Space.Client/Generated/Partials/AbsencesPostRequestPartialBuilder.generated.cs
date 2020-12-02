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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.AbsencesPostRequestPartialBuilder
{
    public static class AbsencesPostRequestPartialExtensions
    {
        public static Partial<AbsencesPostRequest> WithMember(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("member");
        
        public static Partial<AbsencesPostRequest> WithReason(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("reason");
        
        public static Partial<AbsencesPostRequest> WithDescription(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsencesPostRequest> WithLocation(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("location");
        
        public static Partial<AbsencesPostRequest> WithSince(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("since");
        
        public static Partial<AbsencesPostRequest> WithTill(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("till");
        
        public static Partial<AbsencesPostRequest> WithIsAvailable(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("available");
        
        public static Partial<AbsencesPostRequest> WithIcon(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("icon");
        
        public static Partial<AbsencesPostRequest> WithCustomFieldValues(this Partial<AbsencesPostRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<AbsencesPostRequest> WithCustomFieldValues(this Partial<AbsencesPostRequest> it, Func<Partial<CustomFieldInputValue>, Partial<CustomFieldInputValue>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldInputValue>(it)));
        
    }
    
}
