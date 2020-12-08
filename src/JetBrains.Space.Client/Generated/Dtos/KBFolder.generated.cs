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
    public sealed class KBFolder
         : IPropagatePropertyAccessPath
    {
        public KBFolder() { }
        
        public KBFolder(string id, bool archived, string name, List<KBFolder> subfolders, List<KBArticle> articles, KBBook book, string alias, KBFolder? parent = null, KBArticle? cover = null, DateTime? created = null, CPrincipal? createdBy = null, DateTime? updated = null, CPrincipal? updatedBy = null)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            Parent = parent;
            Subfolders = subfolders;
            Articles = articles;
            Book = book;
            Cover = cover;
            Alias = alias;
            Created = created;
            CreatedBy = createdBy;
            Updated = updated;
            UpdatedBy = updatedBy;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KBFolder), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(KBFolder), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(KBFolder), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<KBFolder?> _parent = new PropertyValue<KBFolder?>(nameof(KBFolder), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public KBFolder? Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        private PropertyValue<List<KBFolder>> _subfolders = new PropertyValue<List<KBFolder>>(nameof(KBFolder), nameof(Subfolders));
        
        [Required]
        [JsonPropertyName("subfolders")]
        public List<KBFolder> Subfolders
        {
            get => _subfolders.GetValue();
            set => _subfolders.SetValue(value);
        }
    
        private PropertyValue<List<KBArticle>> _articles = new PropertyValue<List<KBArticle>>(nameof(KBFolder), nameof(Articles));
        
        [Required]
        [JsonPropertyName("articles")]
        public List<KBArticle> Articles
        {
            get => _articles.GetValue();
            set => _articles.SetValue(value);
        }
    
        private PropertyValue<KBBook> _book = new PropertyValue<KBBook>(nameof(KBFolder), nameof(Book));
        
        [Required]
        [JsonPropertyName("book")]
        public KBBook Book
        {
            get => _book.GetValue();
            set => _book.SetValue(value);
        }
    
        private PropertyValue<KBArticle?> _cover = new PropertyValue<KBArticle?>(nameof(KBFolder), nameof(Cover));
        
        [JsonPropertyName("cover")]
        public KBArticle? Cover
        {
            get => _cover.GetValue();
            set => _cover.SetValue(value);
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(KBFolder), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get => _alias.GetValue();
            set => _alias.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _created = new PropertyValue<DateTime?>(nameof(KBFolder), nameof(Created));
        
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(KBFolder), nameof(CreatedBy));
        
        [JsonPropertyName("createdBy")]
        public CPrincipal? CreatedBy
        {
            get => _createdBy.GetValue();
            set => _createdBy.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _updated = new PropertyValue<DateTime?>(nameof(KBFolder), nameof(Updated));
        
        [JsonPropertyName("updated")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _updatedBy = new PropertyValue<CPrincipal?>(nameof(KBFolder), nameof(UpdatedBy));
        
        [JsonPropertyName("updatedBy")]
        public CPrincipal? UpdatedBy
        {
            get => _updatedBy.GetValue();
            set => _updatedBy.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _subfolders.SetAccessPath(path, validateHasBeenSet);
            _articles.SetAccessPath(path, validateHasBeenSet);
            _book.SetAccessPath(path, validateHasBeenSet);
            _cover.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _updatedBy.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
