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
    public sealed class PlanItemChildren
         : IPropagatePropertyAccessPath
    {
        public PlanItemChildren() { }
        
        public PlanItemChildren(string id, List<PlanItem> children)
        {
            Id = id;
            Children = children;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PlanItemChildren), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<List<PlanItem>> _children = new PropertyValue<List<PlanItem>>(nameof(PlanItemChildren), nameof(Children));
        
        [Required]
        [JsonPropertyName("children")]
        public List<PlanItem> Children
        {
            get { return _children.GetValue(); }
            set { _children.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _children.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
