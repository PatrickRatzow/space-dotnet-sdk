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
    public sealed class PlanningTag
         : IPropagatePropertyAccessPath
    {
        public PlanningTag() { }
        
        public PlanningTag(string id, string projectId, string name, PlanningTag? parent = null)
        {
            Id = id;
            ProjectId = projectId;
            Parent = parent;
            Name = name;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PlanningTag), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(PlanningTag), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get => _projectId.GetValue();
            set => _projectId.SetValue(value);
        }
    
        private PropertyValue<PlanningTag?> _parent = new PropertyValue<PlanningTag?>(nameof(PlanningTag), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public PlanningTag? Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PlanningTag), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
