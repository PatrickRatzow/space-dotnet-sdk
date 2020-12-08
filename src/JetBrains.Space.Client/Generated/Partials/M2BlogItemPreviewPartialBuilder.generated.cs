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

namespace JetBrains.Space.Client.M2BlogItemPreviewPartialBuilder
{
    public static class M2BlogItemPreviewPartialExtensions
    {
        public static Partial<M2BlogItemPreview> WithArticle(this Partial<M2BlogItemPreview> it)
            => it.AddFieldName("article");
        
        public static Partial<M2BlogItemPreview> WithArticle(this Partial<M2BlogItemPreview> it, Func<Partial<ArticleRecord>, Partial<ArticleRecord>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecord>(it)));
        
        public static Partial<M2BlogItemPreview> WithArticlePreview(this Partial<M2BlogItemPreview> it)
            => it.AddFieldName("articlePreview");
        
        public static Partial<M2BlogItemPreview> WithArticlePreview(this Partial<M2BlogItemPreview> it, Func<Partial<ArticlePreviewRecord>, Partial<ArticlePreviewRecord>> partialBuilder)
            => it.AddFieldName("articlePreview", partialBuilder(new Partial<ArticlePreviewRecord>(it)));
        
        public static Partial<M2BlogItemPreview> WithArticleDetails(this Partial<M2BlogItemPreview> it)
            => it.AddFieldName("articleDetails");
        
        public static Partial<M2BlogItemPreview> WithArticleDetails(this Partial<M2BlogItemPreview> it, Func<Partial<ArticleDetailsRecord>, Partial<ArticleDetailsRecord>> partialBuilder)
            => it.AddFieldName("articleDetails", partialBuilder(new Partial<ArticleDetailsRecord>(it)));
        
        public static Partial<M2BlogItemPreview> WithArticleChannel(this Partial<M2BlogItemPreview> it)
            => it.AddFieldName("articleChannel");
        
        public static Partial<M2BlogItemPreview> WithArticleChannel(this Partial<M2BlogItemPreview> it, Func<Partial<ArticleChannelRecord>, Partial<ArticleChannelRecord>> partialBuilder)
            => it.AddFieldName("articleChannel", partialBuilder(new Partial<ArticleChannelRecord>(it)));
        
    }
    
}
