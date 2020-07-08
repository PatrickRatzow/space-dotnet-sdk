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
    public sealed class EmojiSearchMatchDataDto
         : IPropagatePropertyAccessPath
    {
        public EmojiSearchMatchDataDto() { }
        
        public EmojiSearchMatchDataDto(string emoji, EmojiSearchMatchType matchType, string? matched = null)
        {
            Emoji = emoji;
            Matched = matched;
            MatchType = matchType;
        }
        
        private PropertyValue<string> _emoji = new PropertyValue<string>(nameof(EmojiSearchMatchDataDto), nameof(Emoji));
        
        [Required]
        [JsonPropertyName("emoji")]
        public string Emoji
        {
            get { return _emoji.GetValue(); }
            set { _emoji.SetValue(value); }
        }
    
        private PropertyValue<string?> _matched = new PropertyValue<string?>(nameof(EmojiSearchMatchDataDto), nameof(Matched));
        
        [JsonPropertyName("matched")]
        public string? Matched
        {
            get { return _matched.GetValue(); }
            set { _matched.SetValue(value); }
        }
    
        private PropertyValue<EmojiSearchMatchType> _matchType = new PropertyValue<EmojiSearchMatchType>(nameof(EmojiSearchMatchDataDto), nameof(MatchType));
        
        [Required]
        [JsonPropertyName("matchType")]
        public EmojiSearchMatchType MatchType
        {
            get { return _matchType.GetValue(); }
            set { _matchType.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _emoji.SetAccessPath(path, validateHasBeenSet);
            _matched.SetAccessPath(path, validateHasBeenSet);
            _matchType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
