// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
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
            get { return _book.GetValue(); }
            set { _book.SetValue(value); }
        }
    
        private PropertyValue<KBFolder?> _folder = new PropertyValue<KBFolder?>(nameof(KbPublicationDetails), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public KBFolder? Folder
        {
            get { return _folder.GetValue(); }
            set { _folder.SetValue(value); }
        }
    
        private PropertyValue<KBArticle?> _articleId = new PropertyValue<KBArticle?>(nameof(KbPublicationDetails), nameof(ArticleId));
        
        [JsonPropertyName("articleId")]
        public KBArticle? ArticleId
        {
            get { return _articleId.GetValue(); }
            set { _articleId.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _book.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _articleId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
