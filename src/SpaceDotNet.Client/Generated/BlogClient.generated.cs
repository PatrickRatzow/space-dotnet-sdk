// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.3094466+00:00
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class BlogClient
    {
        private readonly Connection _connection;
        
        public BlogClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<string> ConvertMarkdownToHTML(ConvertMarkdownToHTMLRequestDto data, Func<Partial<string>, Partial<string>> partialBuilder = null)
            => await _connection.RequestResourceAsync<ConvertMarkdownToHTMLRequestDto, string>("POST", $"api/http/blogs/markdown2html?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<string>()) : new EagerPartial<string>()), data);        
        
        public ArticleClient Articles => new ArticleClient(_connection);
        
        public partial class ArticleClient
        {
            private readonly Connection _connection;
            
            public ArticleClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<ArticleRecordDto> CreateArticle(CreateArticleRequestDto data, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateArticleRequestDto, ArticleRecordDto>("POST", $"api/http/blogs/articles?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ArticleRecordDto>()) : new EagerPartial<ArticleRecordDto>()), data);            
            
            public async Task<Batch<ArticleRecordDto>> GetAllArticles(string? skip = null, int? top = null, string? term = null, SpaceTime? dateFrom = null, SpaceTime? dateTo = null, string? authorId = null, string? teamId = null, string? locationId = null, string? forProfile = null, Func<Partial<Batch<ArticleRecordDto>>, Partial<Batch<ArticleRecordDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<Batch<ArticleRecordDto>>("GET", $"api/http/blogs/articles?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&term={term?.ToString() ?? "null"}&dateFrom={dateFrom?.ToString() ?? "null"}&dateTo={dateTo?.ToString() ?? "null"}&authorId={authorId?.ToString() ?? "null"}&teamId={teamId?.ToString() ?? "null"}&locationId={locationId?.ToString() ?? "null"}&forProfile={forProfile?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<ArticleRecordDto>>()) : new EagerPartial<Batch<ArticleRecordDto>>()));            
            
            public async Task<ArticleRecordDto> GetArticleByAlias(string alias, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<ArticleRecordDto>("GET", $"api/http/blogs/articles/alias:{alias}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ArticleRecordDto>()) : new EagerPartial<ArticleRecordDto>()));            
            
            public async Task<ArticleRecordDto> GetArticle(string id, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<ArticleRecordDto>("GET", $"api/http/blogs/articles/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ArticleRecordDto>()) : new EagerPartial<ArticleRecordDto>()));            
            
            public DraftClient Drafts => new DraftClient(_connection);
            
            public partial class DraftClient
            {
                private readonly Connection _connection;
                
                public DraftClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<BGArticleIdDto> PublishArticle(string draftId, Func<Partial<BGArticleIdDto>, Partial<BGArticleIdDto>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<BGArticleIdDto>("POST", $"api/http/blogs/articles/drafts/{draftId}/publish?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<BGArticleIdDto>()) : new EagerPartial<BGArticleIdDto>()));                
                
                public async Task<DRDraftIdDto> GetDraftByArticleId(string articleId, Func<Partial<DRDraftIdDto>, Partial<DRDraftIdDto>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<DRDraftIdDto>("GET", $"api/http/blogs/articles/drafts/article-id:{articleId}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DRDraftIdDto>()) : new EagerPartial<DRDraftIdDto>()));                
                
                public async Task UnpublishArticle(string draftId)
                    => await _connection.RequestResourceAsync("DELETE", $"api/http/blogs/articles/drafts/{draftId}/unpublish");                
                
            }
            
        }
        
        public DateClient Dates => new DateClient(_connection);
        
        public partial class DateClient
        {
            private readonly Connection _connection;
            
            public DateClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<BGDatesDto> GetDates(Func<Partial<BGDatesDto>, Partial<BGDatesDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<BGDatesDto>("GET", $"api/http/blogs/dates?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<BGDatesDto>()) : new EagerPartial<BGDatesDto>()));            
            
        }
        
        public StatClient Stats => new StatClient(_connection);
        
        public partial class StatClient
        {
            private readonly Connection _connection;
            
            public StatClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<BGStatsDto> GetStats(SpaceTime? dateFrom = null, SpaceTime? dateTo = null, string? authorId = null, string? teamId = null, string? locationId = null, Func<Partial<BGStatsDto>, Partial<BGStatsDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<BGStatsDto>("GET", $"api/http/blogs/stats?dateFrom={dateFrom?.ToString() ?? "null"}&dateTo={dateTo?.ToString() ?? "null"}&authorId={authorId?.ToString() ?? "null"}&teamId={teamId?.ToString() ?? "null"}&locationId={locationId?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<BGStatsDto>()) : new EagerPartial<BGStatsDto>()));            
            
        }
        
    }
    
}
