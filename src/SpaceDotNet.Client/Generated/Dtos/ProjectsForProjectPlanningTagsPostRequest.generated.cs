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
    public class ProjectsForProjectPlanningTagsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPlanningTagsPostRequest() { }
        
        public ProjectsForProjectPlanningTagsPostRequest(List<string> path, string? parentTagId = null)
        {
            ParentTagId = parentTagId;
            Path = path;
        }
        
        private PropertyValue<string?> _parentTagId = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningTagsPostRequest), nameof(ParentTagId));
        
        [JsonPropertyName("parentTagId")]
        public string? ParentTagId
        {
            get { return _parentTagId.GetValue(); }
            set { _parentTagId.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _path = new PropertyValue<List<string>>(nameof(ProjectsForProjectPlanningTagsPostRequest), nameof(Path));
        
        [Required]
        [JsonPropertyName("path")]
        public List<string> Path
        {
            get { return _path.GetValue(); }
            set { _path.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _parentTagId.SetAccessPath(path, validateHasBeenSet);
            _path.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}