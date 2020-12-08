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

namespace JetBrains.Space.Client.M2ChannelContentArticlePartialBuilder
{
    public static class M2ChannelContentArticlePartialExtensions
    {
        public static Partial<M2ChannelContentArticle> WithArticle(this Partial<M2ChannelContentArticle> it)
            => it.AddFieldName("article");
        
        public static Partial<M2ChannelContentArticle> WithArticle(this Partial<M2ChannelContentArticle> it, Func<Partial<ArticleRecord>, Partial<ArticleRecord>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecord>(it)));
        
        public static Partial<M2ChannelContentArticle> WithArticleContent(this Partial<M2ChannelContentArticle> it)
            => it.AddFieldName("articleContent");
        
        public static Partial<M2ChannelContentArticle> WithArticleContent(this Partial<M2ChannelContentArticle> it, Func<Partial<ArticleContentRecord>, Partial<ArticleContentRecord>> partialBuilder)
            => it.AddFieldName("articleContent", partialBuilder(new Partial<ArticleContentRecord>(it)));
        
        public static Partial<M2ChannelContentArticle> WithDetails(this Partial<M2ChannelContentArticle> it)
            => it.AddFieldName("details");
        
        public static Partial<M2ChannelContentArticle> WithDetails(this Partial<M2ChannelContentArticle> it, Func<Partial<ArticleDetailsRecord>, Partial<ArticleDetailsRecord>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<ArticleDetailsRecord>(it)));
        
        public static Partial<M2ChannelContentArticle> WithChannel(this Partial<M2ChannelContentArticle> it)
            => it.AddFieldName("channel");
        
        public static Partial<M2ChannelContentArticle> WithChannel(this Partial<M2ChannelContentArticle> it, Func<Partial<ArticleChannelRecord>, Partial<ArticleChannelRecord>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<ArticleChannelRecord>(it)));
        
    }
    
}
