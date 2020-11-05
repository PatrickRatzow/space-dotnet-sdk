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

namespace JetBrains.Space.Client.PRRepositoryInfoPartialBuilder
{
    public static class PRRepositoryInfoPartialExtensions
    {
        public static Partial<PRRepositoryInfo> WithId(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("id");
        
        public static Partial<PRRepositoryInfo> WithName(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("name");
        
        public static Partial<PRRepositoryInfo> WithDescription(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("description");
        
        public static Partial<PRRepositoryInfo> WithLatestActivity(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("latestActivity");
        
        public static Partial<PRRepositoryInfo> WithProxyPushNotification(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("proxyPushNotification");
        
        public static Partial<PRRepositoryInfo> WithState(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("state");
        
        public static Partial<PRRepositoryInfo> WithState(this Partial<PRRepositoryInfo> it, Func<Partial<RepositoryState>, Partial<RepositoryState>> partialBuilder)
            => it.AddFieldName("state", partialBuilder(new Partial<RepositoryState>(it)));
        
        public static Partial<PRRepositoryInfo> WithInitProgress(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("initProgress");
        
        public static Partial<PRRepositoryInfo> WithReadmeName(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("readmeName");
        
        public static Partial<PRRepositoryInfo> WithMonthlyActivity(this Partial<PRRepositoryInfo> it)
            => it.AddFieldName("monthlyActivity");
        
        public static Partial<PRRepositoryInfo> WithMonthlyActivity(this Partial<PRRepositoryInfo> it, Func<Partial<RepositoryActivity>, Partial<RepositoryActivity>> partialBuilder)
            => it.AddFieldName("monthlyActivity", partialBuilder(new Partial<RepositoryActivity>(it)));
        
    }
    
}