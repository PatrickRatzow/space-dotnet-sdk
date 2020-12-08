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
    public sealed class FeatureFlag
         : IPropagatePropertyAccessPath
    {
        public FeatureFlag() { }
        
        public FeatureFlag(string name, string description, FeatureFlagStatus status, string owner, DateTime? introduced = null)
        {
            Name = name;
            Description = description;
            Status = status;
            Owner = owner;
            Introduced = introduced;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(FeatureFlag), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(FeatureFlag), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<FeatureFlagStatus> _status = new PropertyValue<FeatureFlagStatus>(nameof(FeatureFlag), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public FeatureFlagStatus Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        private PropertyValue<string> _owner = new PropertyValue<string>(nameof(FeatureFlag), nameof(Owner));
        
        [Required]
        [JsonPropertyName("owner")]
        public string Owner
        {
            get => _owner.GetValue();
            set => _owner.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _introduced = new PropertyValue<DateTime?>(nameof(FeatureFlag), nameof(Introduced));
        
        [JsonPropertyName("introduced")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Introduced
        {
            get => _introduced.GetValue();
            set => _introduced.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _introduced.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
