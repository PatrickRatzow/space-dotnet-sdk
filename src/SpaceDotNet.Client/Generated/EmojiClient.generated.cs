// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    public partial class EmojiClient
    {
        private readonly Connection _connection;
        
        public EmojiClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Add custom emoji.
        /// </summary>
        public async Task AddAsync(string emoji, string attachmentId)
            => await _connection.RequestResourceAsync("POST", $"api/http/emojis/add", new EmojisAddRequest{ Emoji = emoji, AttachmentId = attachmentId });
    
        /// <summary>
        /// Delete an emoji by its name.
        /// </summary>
        public async Task DeleteAsync(string emoji)
            => await _connection.RequestResourceAsync("POST", $"api/http/emojis/delete", new EmojisDeleteRequest{ Emoji = emoji });
    
        /// <summary>
        /// Record emojis usage and update frequently used list.
        /// </summary>
        public async Task RecordUsageAsync(List<string> emojis)
            => await _connection.RequestResourceAsync("POST", $"api/http/emojis/record-usage", new EmojisRecordUsageRequest{ Emojis = emojis });
    
        /// <summary>
        /// Check whether a given emoji name exists.
        /// </summary>
        public async Task<bool> ExistsAsync(string emoji)
            => await _connection.RequestResourceAsync<bool>("GET", $"api/http/emojis/exists?emoji={emoji.ToString()}");
    
        /// <summary>
        /// List frequently used emojis.
        /// </summary>
        public async Task<List<string>> FrequentlyUsedAsync()
            => await _connection.RequestResourceAsync<List<string>>("GET", $"api/http/emojis/frequently-used");
    
        /// <summary>
        /// Search for emoji.
        /// </summary>
        public async Task<Batch<EmojiSearchMatchDataDto>> SearchAsync(string query, string? skip = null, int? top = null, Func<Partial<Batch<EmojiSearchMatchDataDto>>, Partial<Batch<EmojiSearchMatchDataDto>>>? partial = null)
            => await _connection.RequestResourceAsync<Batch<EmojiSearchMatchDataDto>>("GET", $"api/http/emojis/search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<EmojiSearchMatchDataDto>>()) : Partial<Batch<EmojiSearchMatchDataDto>>.Default())}");
        
        /// <summary>
        /// Search for emoji.
        /// </summary>
        public IAsyncEnumerable<EmojiSearchMatchDataDto> SearchAsyncEnumerable(string query, string? skip = null, int? top = null, Func<Partial<EmojiSearchMatchDataDto>, Partial<EmojiSearchMatchDataDto>>? partial = null)
            => BatchEnumerator.AllItems(batchSkip => SearchAsync(query: query, top: top, skip: batchSkip, partial: builder => Partial<Batch<EmojiSearchMatchDataDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<EmojiSearchMatchDataDto>.Default())), skip);
    
    }
    
}
