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
    public class TeamDirectoryProfilesForProfileChecklistsImportPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfileChecklistsImportPostRequest() { }
        
        public TeamDirectoryProfilesForProfileChecklistsImportPostRequest(string name, string tabIndentedLines)
        {
            Name = name;
            TabIndentedLines = tabIndentedLines;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileChecklistsImportPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _tabIndentedLines = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileChecklistsImportPostRequest), nameof(TabIndentedLines));
        
        [Required]
        [JsonPropertyName("tabIndentedLines")]
        public string TabIndentedLines
        {
            get => _tabIndentedLines.GetValue();
            set => _tabIndentedLines.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _tabIndentedLines.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
