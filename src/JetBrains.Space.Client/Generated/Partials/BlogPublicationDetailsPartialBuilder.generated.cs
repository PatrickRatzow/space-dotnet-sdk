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

namespace JetBrains.Space.Client.BlogPublicationDetailsPartialBuilder
{
    public static class BlogPublicationDetailsPartialExtensions
    {
        public static Partial<BlogPublicationDetails> WithTeamId(this Partial<BlogPublicationDetails> it)
            => it.AddFieldName("teamId");
        
        public static Partial<BlogPublicationDetails> WithTeamId(this Partial<BlogPublicationDetails> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teamId", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<BlogPublicationDetails> WithTeams(this Partial<BlogPublicationDetails> it)
            => it.AddFieldName("teams");
        
        public static Partial<BlogPublicationDetails> WithTeams(this Partial<BlogPublicationDetails> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<BlogPublicationDetails> WithLocationId(this Partial<BlogPublicationDetails> it)
            => it.AddFieldName("locationId");
        
        public static Partial<BlogPublicationDetails> WithLocationId(this Partial<BlogPublicationDetails> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locationId", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<BlogPublicationDetails> WithLocations(this Partial<BlogPublicationDetails> it)
            => it.AddFieldName("locations");
        
        public static Partial<BlogPublicationDetails> WithLocations(this Partial<BlogPublicationDetails> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<BlogPublicationDetails> WithEvent(this Partial<BlogPublicationDetails> it)
            => it.AddFieldName("event");
        
        public static Partial<BlogPublicationDetails> WithEvent(this Partial<BlogPublicationDetails> it, Func<Partial<CalendarEvent>, Partial<CalendarEvent>> partialBuilder)
            => it.AddFieldName("event", partialBuilder(new Partial<CalendarEvent>(it)));
        
        public static Partial<BlogPublicationDetails> WithArticle(this Partial<BlogPublicationDetails> it)
            => it.AddFieldName("article");
        
        public static Partial<BlogPublicationDetails> WithArticle(this Partial<BlogPublicationDetails> it, Func<Partial<ArticleRecord>, Partial<ArticleRecord>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecord>(it)));
        
    }
    
}
