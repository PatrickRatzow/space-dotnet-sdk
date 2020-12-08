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
    public sealed class MavenPackageParent
         : IPropagatePropertyAccessPath
    {
        public MavenPackageParent() { }
        
        public MavenPackageParent(string group, string artifact, string version)
        {
            Group = group;
            Artifact = artifact;
            Version = version;
        }
        
        private PropertyValue<string> _group = new PropertyValue<string>(nameof(MavenPackageParent), nameof(Group));
        
        [Required]
        [JsonPropertyName("group")]
        public string Group
        {
            get => _group.GetValue();
            set => _group.SetValue(value);
        }
    
        private PropertyValue<string> _artifact = new PropertyValue<string>(nameof(MavenPackageParent), nameof(Artifact));
        
        [Required]
        [JsonPropertyName("artifact")]
        public string Artifact
        {
            get => _artifact.GetValue();
            set => _artifact.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(MavenPackageParent), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _group.SetAccessPath(path, validateHasBeenSet);
            _artifact.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
