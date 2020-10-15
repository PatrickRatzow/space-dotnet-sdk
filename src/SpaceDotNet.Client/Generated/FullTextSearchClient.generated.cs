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
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class FullTextSearchClient
    {
        private readonly Connection _connection;
        
        public FullTextSearchClient(Connection connection)
        {
            _connection = connection;
        }
        
        public EntityClient Entities => new EntityClient(_connection);
        
        public partial class EntityClient
        {
            private readonly Connection _connection;
            
            public EntityClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Entities available for search
            /// </summary>
            public async Task<List<EntityType>> GetAllEntitiesAsync(Func<Partial<EntityType>, Partial<EntityType>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<EntityType>>("GET", $"api/http/full-text-search/entities?$fields={(partial != null ? partial(new Partial<EntityType>()) : Partial<EntityType>.Default())}", cancellationToken);
        
        }
    
        public SearchClient Search => new SearchClient(_connection);
        
        public partial class SearchClient
        {
            private readonly Connection _connection;
            
            public SearchClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all supported entities.
            /// </summary>
            public async Task<Batch<EntityHit>> GetAllSearchAsync(string query, bool quick = false, List<string>? keys = null, string? skip = null, int? top = 100, EntityFilter? filter = null, Func<Partial<Batch<EntityHit>>, Partial<Batch<EntityHit>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<EntityHit>>("GET", $"api/http/full-text-search/search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&quick={quick.ToString("l")}&keys={(keys ?? new List<string>()).JoinToString("keys", it => it.ToString())}&filter={filter?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<EntityHit>>()) : Partial<Batch<EntityHit>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all supported entities.
            /// </summary>
            public IAsyncEnumerable<EntityHit> GetAllSearchAsyncEnumerable(string query, bool quick = false, List<string>? keys = null, string? skip = null, int? top = 100, EntityFilter? filter = null, Func<Partial<EntityHit>, Partial<EntityHit>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllSearchAsync(query: query, quick: quick, keys: keys, top: top, filter: filter, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<EntityHit>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<EntityHit>.Default())), skip, cancellationToken);
        
        }
    
    }
    
}
