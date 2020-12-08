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
    public sealed class KbPublicationDetails
         : PublicationDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "KbPublicationDetails";
        
        public KbPublicationDetails() { }
        
        public KbPublicationDetails(KBBook? book = null, KBFolder? folder = null, KBArticle? articleId = null)
        {
            Book = book;
            Folder = folder;
            ArticleId = articleId;
        }
        
        private PropertyValue<KBBook?> _book = new PropertyValue<KBBook?>(nameof(KbPublicationDetails), nameof(Book));
        
        [JsonPropertyName("book")]
        public KBBook? Book
        {
            get => _book.GetValue();
            set => _book.SetValue(value);
        }
    
        private PropertyValue<KBFolder?> _folder = new PropertyValue<KBFolder?>(nameof(KbPublicationDetails), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public KBFolder? Folder
        {
            get => _folder.GetValue();
            set => _folder.SetValue(value);
        }
    
        private PropertyValue<KBArticle?> _articleId = new PropertyValue<KBArticle?>(nameof(KbPublicationDetails), nameof(ArticleId));
        
        [JsonPropertyName("articleId")]
        public KBArticle? ArticleId
        {
            get => _articleId.GetValue();
            set => _articleId.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _book.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _articleId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
