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
    public sealed class AbsenceReasonRecord
         : IPropagatePropertyAccessPath
    {
        public AbsenceReasonRecord() { }
        
        public AbsenceReasonRecord(string id, bool archived, string name, string description, bool defaultAvailability, bool approvalRequired, string icon)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            Description = description;
            IsDefaultAvailability = defaultAvailability;
            IsApprovalRequired = approvalRequired;
            Icon = icon;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(AbsenceReasonRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _defaultAvailability = new PropertyValue<bool>(nameof(AbsenceReasonRecord), nameof(IsDefaultAvailability));
        
        [Required]
        [JsonPropertyName("defaultAvailability")]
        public bool IsDefaultAvailability
        {
            get { return _defaultAvailability.GetValue(); }
            set { _defaultAvailability.SetValue(value); }
        }
    
        private PropertyValue<bool> _approvalRequired = new PropertyValue<bool>(nameof(AbsenceReasonRecord), nameof(IsApprovalRequired));
        
        [Required]
        [JsonPropertyName("approvalRequired")]
        public bool IsApprovalRequired
        {
            get { return _approvalRequired.GetValue(); }
            set { _approvalRequired.SetValue(value); }
        }
    
        private PropertyValue<string> _icon = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Icon));
        
        [Required]
        [JsonPropertyName("icon")]
        public string Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _defaultAvailability.SetAccessPath(path, validateHasBeenSet);
            _approvalRequired.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
