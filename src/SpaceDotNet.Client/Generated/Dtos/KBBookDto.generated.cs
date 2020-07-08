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
    public sealed class KBBookDto
         : IPropagatePropertyAccessPath
    {
        public KBBookDto() { }
        
        public KBBookDto(string id, bool archived, string name, string summary, long updated, string alias, List<KBBookContextDto> contexts, List<TDLocationDto> locations, List<TDTeamDto> teams, KBFolderDto rootFolder)
        {
            Id = id;
            Archived = archived;
            Name = name;
            Summary = summary;
            Updated = updated;
            Alias = alias;
            Contexts = contexts;
            Locations = locations;
            Teams = teams;
            RootFolder = rootFolder;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KBBookDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(KBBookDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(KBBookDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(KBBookDto), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get { return _summary.GetValue(); }
            set { _summary.SetValue(value); }
        }
    
        private PropertyValue<long> _updated = new PropertyValue<long>(nameof(KBBookDto), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        public long Updated
        {
            get { return _updated.GetValue(); }
            set { _updated.SetValue(value); }
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(KBBookDto), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get { return _alias.GetValue(); }
            set { _alias.SetValue(value); }
        }
    
        private PropertyValue<List<KBBookContextDto>> _contexts = new PropertyValue<List<KBBookContextDto>>(nameof(KBBookDto), nameof(Contexts));
        
        [Required]
        [JsonPropertyName("contexts")]
        public List<KBBookContextDto> Contexts
        {
            get { return _contexts.GetValue(); }
            set { _contexts.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocationDto>> _locations = new PropertyValue<List<TDLocationDto>>(nameof(KBBookDto), nameof(Locations));
        
        [Required]
        [JsonPropertyName("locations")]
        public List<TDLocationDto> Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeamDto>> _teams = new PropertyValue<List<TDTeamDto>>(nameof(KBBookDto), nameof(Teams));
        
        [Required]
        [JsonPropertyName("teams")]
        public List<TDTeamDto> Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<KBFolderDto> _rootFolder = new PropertyValue<KBFolderDto>(nameof(KBBookDto), nameof(RootFolder));
        
        [Required]
        [JsonPropertyName("rootFolder")]
        public KBFolderDto RootFolder
        {
            get { return _rootFolder.GetValue(); }
            set { _rootFolder.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _summary.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
            _contexts.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _rootFolder.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
