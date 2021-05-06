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
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ApplicationSshKeyWebhookEventPartialBuilder
{
    public static class ApplicationSshKeyWebhookEventPartialExtensions
    {
        public static Partial<ApplicationSshKeyWebhookEvent> WithMeta(this Partial<ApplicationSshKeyWebhookEvent> it)
            => it.AddFieldName("meta");
        
        public static Partial<ApplicationSshKeyWebhookEvent> WithMeta(this Partial<ApplicationSshKeyWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
            => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
        
        public static Partial<ApplicationSshKeyWebhookEvent> WithApplication(this Partial<ApplicationSshKeyWebhookEvent> it)
            => it.AddFieldName("application");
        
        public static Partial<ApplicationSshKeyWebhookEvent> WithApplication(this Partial<ApplicationSshKeyWebhookEvent> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
            => it.AddFieldName("application", partialBuilder(new Partial<ESApp>(it)));
        
        public static Partial<ApplicationSshKeyWebhookEvent> WithFingerprint(this Partial<ApplicationSshKeyWebhookEvent> it)
            => it.AddFieldName("fingerprint");
        
        public static Partial<ApplicationSshKeyWebhookEvent> WithComment(this Partial<ApplicationSshKeyWebhookEvent> it)
            => it.AddFieldName("comment");
        
    }
    
}