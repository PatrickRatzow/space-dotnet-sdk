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
    public sealed class DocumentFolderRecord
         : IPropagatePropertyAccessPath
    {
        public DocumentFolderRecord() { }
        
        public DocumentFolderRecord(string id, bool archived, string name, List<DocumentFolderRecord> subfolders, List<DRDraftHeader> documents, TDMemberProfile owner, string alias, DocumentFolderRecord? parent = null, DateTime? created = null, CPrincipal? createdBy = null, DateTime? updated = null, CPrincipal? updatedBy = null)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            Parent = parent;
            Subfolders = subfolders;
            Documents = documents;
            Owner = owner;
            Alias = alias;
            Created = created;
            CreatedBy = createdBy;
            Updated = updated;
            UpdatedBy = updatedBy;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DocumentFolderRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(DocumentFolderRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(DocumentFolderRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<DocumentFolderRecord?> _parent = new PropertyValue<DocumentFolderRecord?>(nameof(DocumentFolderRecord), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public DocumentFolderRecord? Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        private PropertyValue<List<DocumentFolderRecord>> _subfolders = new PropertyValue<List<DocumentFolderRecord>>(nameof(DocumentFolderRecord), nameof(Subfolders));
        
        [Required]
        [JsonPropertyName("subfolders")]
        public List<DocumentFolderRecord> Subfolders
        {
            get => _subfolders.GetValue();
            set => _subfolders.SetValue(value);
        }
    
        private PropertyValue<List<DRDraftHeader>> _documents = new PropertyValue<List<DRDraftHeader>>(nameof(DocumentFolderRecord), nameof(Documents));
        
        [Required]
        [JsonPropertyName("documents")]
        public List<DRDraftHeader> Documents
        {
            get => _documents.GetValue();
            set => _documents.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile> _owner = new PropertyValue<TDMemberProfile>(nameof(DocumentFolderRecord), nameof(Owner));
        
        [Required]
        [JsonPropertyName("owner")]
        public TDMemberProfile Owner
        {
            get => _owner.GetValue();
            set => _owner.SetValue(value);
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(DocumentFolderRecord), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get => _alias.GetValue();
            set => _alias.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _created = new PropertyValue<DateTime?>(nameof(DocumentFolderRecord), nameof(Created));
        
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(DocumentFolderRecord), nameof(CreatedBy));
        
        [JsonPropertyName("createdBy")]
        public CPrincipal? CreatedBy
        {
            get => _createdBy.GetValue();
            set => _createdBy.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _updated = new PropertyValue<DateTime?>(nameof(DocumentFolderRecord), nameof(Updated));
        
        [JsonPropertyName("updated")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _updatedBy = new PropertyValue<CPrincipal?>(nameof(DocumentFolderRecord), nameof(UpdatedBy));
        
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
            _documents.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _updatedBy.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
