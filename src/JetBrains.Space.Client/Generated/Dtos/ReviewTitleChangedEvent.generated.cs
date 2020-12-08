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
    public sealed class ReviewTitleChangedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ReviewTitleChangedEvent";
        
        public ReviewTitleChangedEvent() { }
        
        public ReviewTitleChangedEvent(string oldTitle, string newTitle)
        {
            OldTitle = oldTitle;
            NewTitle = newTitle;
        }
        
        private PropertyValue<string> _oldTitle = new PropertyValue<string>(nameof(ReviewTitleChangedEvent), nameof(OldTitle));
        
        [Required]
        [JsonPropertyName("oldTitle")]
        public string OldTitle
        {
            get => _oldTitle.GetValue();
            set => _oldTitle.SetValue(value);
        }
    
        private PropertyValue<string> _newTitle = new PropertyValue<string>(nameof(ReviewTitleChangedEvent), nameof(NewTitle));
        
        [Required]
        [JsonPropertyName("newTitle")]
        public string NewTitle
        {
            get => _newTitle.GetValue();
            set => _newTitle.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _oldTitle.SetAccessPath(path, validateHasBeenSet);
            _newTitle.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
