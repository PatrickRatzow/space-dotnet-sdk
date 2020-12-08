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
    public sealed class M2SharedChannelContent
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2SharedChannelContent";
        
        public M2SharedChannelContent() { }
        
        public M2SharedChannelContent(string name, string group, M2Access access, string description, ChannelSpecificDefaults notificationDefaults, string? iconId = null, List<TDTeam>? teams = null, bool? canEdit = null)
        {
            Name = name;
            Group = group;
            Access = access;
            Description = description;
            IconId = iconId;
            NotificationDefaults = notificationDefaults;
            Teams = teams;
            CanEdit = canEdit;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(M2SharedChannelContent), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _group = new PropertyValue<string>(nameof(M2SharedChannelContent), nameof(Group));
        
        [Required]
        [JsonPropertyName("group")]
        public string Group
        {
            get => _group.GetValue();
            set => _group.SetValue(value);
        }
    
        private PropertyValue<M2Access> _access = new PropertyValue<M2Access>(nameof(M2SharedChannelContent), nameof(Access));
        
        [Required]
        [JsonPropertyName("access")]
        public M2Access Access
        {
            get => _access.GetValue();
            set => _access.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(M2SharedChannelContent), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<string?> _iconId = new PropertyValue<string?>(nameof(M2SharedChannelContent), nameof(IconId));
        
        [JsonPropertyName("iconId")]
        public string? IconId
        {
            get => _iconId.GetValue();
            set => _iconId.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2SharedChannelContent), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(M2SharedChannelContent), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<TDTeam>? Teams
        {
            get => _teams.GetValue();
            set => _teams.SetValue(value);
        }
    
        private PropertyValue<bool?> _canEdit = new PropertyValue<bool?>(nameof(M2SharedChannelContent), nameof(CanEdit));
        
        [JsonPropertyName("canEdit")]
        public bool? CanEdit
        {
            get => _canEdit.GetValue();
            set => _canEdit.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _group.SetAccessPath(path, validateHasBeenSet);
            _access.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _iconId.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _canEdit.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
