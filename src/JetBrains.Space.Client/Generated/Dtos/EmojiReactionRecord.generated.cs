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

namespace JetBrains.Space.Client
{
    public sealed class EmojiReactionRecord
         : IPropagatePropertyAccessPath
    {
        public EmojiReactionRecord() { }
        
        public EmojiReactionRecord(string id, string itemId, string emoji, int count, bool meReacted, long order)
        {
            Id = id;
            ItemId = itemId;
            Emoji = emoji;
            Count = count;
            IsMeReacted = meReacted;
            Order = order;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(EmojiReactionRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _itemId = new PropertyValue<string>(nameof(EmojiReactionRecord), nameof(ItemId));
        
        [Required]
        [JsonPropertyName("itemId")]
        public string ItemId
        {
            get => _itemId.GetValue();
            set => _itemId.SetValue(value);
        }
    
        private PropertyValue<string> _emoji = new PropertyValue<string>(nameof(EmojiReactionRecord), nameof(Emoji));
        
        [Required]
        [JsonPropertyName("emoji")]
        public string Emoji
        {
            get => _emoji.GetValue();
            set => _emoji.SetValue(value);
        }
    
        private PropertyValue<int> _count = new PropertyValue<int>(nameof(EmojiReactionRecord), nameof(Count));
        
        [Required]
        [JsonPropertyName("count")]
        public int Count
        {
            get => _count.GetValue();
            set => _count.SetValue(value);
        }
    
        private PropertyValue<bool> _meReacted = new PropertyValue<bool>(nameof(EmojiReactionRecord), nameof(IsMeReacted));
        
        [Required]
        [JsonPropertyName("meReacted")]
        public bool IsMeReacted
        {
            get => _meReacted.GetValue();
            set => _meReacted.SetValue(value);
        }
    
        private PropertyValue<long> _order = new PropertyValue<long>(nameof(EmojiReactionRecord), nameof(Order));
        
        [Required]
        [JsonPropertyName("order")]
        public long Order
        {
            get => _order.GetValue();
            set => _order.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _itemId.SetAccessPath(path, validateHasBeenSet);
            _emoji.SetAccessPath(path, validateHasBeenSet);
            _count.SetAccessPath(path, validateHasBeenSet);
            _meReacted.SetAccessPath(path, validateHasBeenSet);
            _order.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
