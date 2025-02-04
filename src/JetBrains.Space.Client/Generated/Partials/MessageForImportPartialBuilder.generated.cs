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

namespace JetBrains.Space.Client.MessageForImportPartialBuilder
{
    public static class MessageForImportPartialExtensions
    {
        public static Partial<MessageForImport> WithAuthorPrincipalId(this Partial<MessageForImport> it)
            => it.AddFieldName("authorPrincipalId");
        
        public static Partial<MessageForImport> WithText(this Partial<MessageForImport> it)
            => it.AddFieldName("text");
        
        public static Partial<MessageForImport> WithCreatedAtUtc(this Partial<MessageForImport> it)
            => it.AddFieldName("createdAtUtc");
        
        public static Partial<MessageForImport> WithAttachments(this Partial<MessageForImport> it)
            => it.AddFieldName("attachments");
        
        public static Partial<MessageForImport> WithAttachments(this Partial<MessageForImport> it, Func<Partial<AttachmentIn>, Partial<AttachmentIn>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentIn>(it)));
        
    }
    
}
