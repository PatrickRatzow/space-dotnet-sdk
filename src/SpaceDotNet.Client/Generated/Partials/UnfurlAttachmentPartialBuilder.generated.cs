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

namespace SpaceDotNet.Client.UnfurlAttachmentPartialBuilder
{
    public static class UnfurlAttachmentPartialExtensions
    {
        public static Partial<UnfurlAttachment> WithUnfurl(this Partial<UnfurlAttachment> it)
            => it.AddFieldName("unfurl");
        
        public static Partial<UnfurlAttachment> WithUnfurl(this Partial<UnfurlAttachment> it, Func<Partial<Unfurl>, Partial<Unfurl>> partialBuilder)
            => it.AddFieldName("unfurl", partialBuilder(new Partial<Unfurl>(it)));
        
        public static Partial<UnfurlAttachment> WithId(this Partial<UnfurlAttachment> it)
            => it.AddFieldName("id");
        
    }
    
}
