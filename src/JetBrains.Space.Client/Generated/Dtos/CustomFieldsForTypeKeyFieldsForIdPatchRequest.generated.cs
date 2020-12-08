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
    public class CustomFieldsForTypeKeyFieldsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public CustomFieldsForTypeKeyFieldsForIdPatchRequest() { }
        
        public CustomFieldsForTypeKeyFieldsForIdPatchRequest(ExtendedTypeScope scope, string? name = null, string? description = null, CFConstraint? constraint = null, bool? required = null, bool? @private = null, AccessType? access = null, CFInputValue? defaultValue = null, List<EnumValueData>? enumValues = null, CFEnumValuesModification? openEnumValuesModification = null)
        {
            Name = name;
            Description = description;
            Constraint = constraint;
            IsRequired = required;
            IsPrivate = @private;
            Access = access;
            DefaultValue = defaultValue;
            EnumValues = enumValues;
            OpenEnumValuesModification = openEnumValuesModification;
            Scope = scope;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Constraint));
        
        [JsonPropertyName("constraint")]
        public CFConstraint? Constraint
        {
            get => _constraint.GetValue();
            set => _constraint.SetValue(value);
        }
    
        private PropertyValue<bool?> _required = new PropertyValue<bool?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(IsRequired));
        
        [JsonPropertyName("required")]
        public bool? IsRequired
        {
            get => _required.GetValue();
            set => _required.SetValue(value);
        }
    
        private PropertyValue<bool?> _private = new PropertyValue<bool?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(IsPrivate));
        
        [JsonPropertyName("private")]
        public bool? IsPrivate
        {
            get => _private.GetValue();
            set => _private.SetValue(value);
        }
    
        private PropertyValue<AccessType?> _access = new PropertyValue<AccessType?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessType? Access
        {
            get => _access.GetValue();
            set => _access.SetValue(value);
        }
    
        private PropertyValue<CFInputValue?> _defaultValue = new PropertyValue<CFInputValue?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(DefaultValue));
        
        [JsonPropertyName("defaultValue")]
        public CFInputValue? DefaultValue
        {
            get => _defaultValue.GetValue();
            set => _defaultValue.SetValue(value);
        }
    
        private PropertyValue<List<EnumValueData>?> _enumValues = new PropertyValue<List<EnumValueData>?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(EnumValues));
        
        [JsonPropertyName("enumValues")]
        public List<EnumValueData>? EnumValues
        {
            get => _enumValues.GetValue();
            set => _enumValues.SetValue(value);
        }
    
        private PropertyValue<CFEnumValuesModification?> _openEnumValuesModification = new PropertyValue<CFEnumValuesModification?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(OpenEnumValuesModification));
        
        [JsonPropertyName("openEnumValuesModification")]
        public CFEnumValuesModification? OpenEnumValuesModification
        {
            get => _openEnumValuesModification.GetValue();
            set => _openEnumValuesModification.SetValue(value);
        }
    
        private PropertyValue<ExtendedTypeScope> _scope = new PropertyValue<ExtendedTypeScope>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public ExtendedTypeScope Scope
        {
            get => _scope.GetValue();
            set => _scope.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _constraint.SetAccessPath(path, validateHasBeenSet);
            _required.SetAccessPath(path, validateHasBeenSet);
            _private.SetAccessPath(path, validateHasBeenSet);
            _access.SetAccessPath(path, validateHasBeenSet);
            _defaultValue.SetAccessPath(path, validateHasBeenSet);
            _enumValues.SetAccessPath(path, validateHasBeenSet);
            _openEnumValuesModification.SetAccessPath(path, validateHasBeenSet);
            _scope.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
