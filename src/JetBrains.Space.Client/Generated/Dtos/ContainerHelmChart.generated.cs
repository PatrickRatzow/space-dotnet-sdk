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
    public sealed class ContainerHelmChart
         : IPropagatePropertyAccessPath
    {
        public ContainerHelmChart() { }
        
        public ContainerHelmChart(List<ContainerHelmChartDependency> dependencies, string? name = null, string? description = null, List<string>? tags = null, string? projectUrl = null, string? sourceUrl = null, string? version = null, string? apiVersion = null, string? appVersion = null, string? type = null)
        {
            Name = name;
            Description = description;
            Tags = tags;
            ProjectUrl = projectUrl;
            SourceUrl = sourceUrl;
            Version = version;
            ApiVersion = apiVersion;
            AppVersion = appVersion;
            Dependencies = dependencies;
            Type = type;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(ContainerHelmChart), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        private PropertyValue<string?> _projectUrl = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(ProjectUrl));
        
        [JsonPropertyName("projectUrl")]
        public string? ProjectUrl
        {
            get => _projectUrl.GetValue();
            set => _projectUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _sourceUrl = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(SourceUrl));
        
        [JsonPropertyName("sourceUrl")]
        public string? SourceUrl
        {
            get => _sourceUrl.GetValue();
            set => _sourceUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _version = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(Version));
        
        [JsonPropertyName("version")]
        public string? Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<string?> _apiVersion = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(ApiVersion));
        
        [JsonPropertyName("apiVersion")]
        public string? ApiVersion
        {
            get => _apiVersion.GetValue();
            set => _apiVersion.SetValue(value);
        }
    
        private PropertyValue<string?> _appVersion = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(AppVersion));
        
        [JsonPropertyName("appVersion")]
        public string? AppVersion
        {
            get => _appVersion.GetValue();
            set => _appVersion.SetValue(value);
        }
    
        private PropertyValue<List<ContainerHelmChartDependency>> _dependencies = new PropertyValue<List<ContainerHelmChartDependency>>(nameof(ContainerHelmChart), nameof(Dependencies));
        
        [Required]
        [JsonPropertyName("dependencies")]
        public List<ContainerHelmChartDependency> Dependencies
        {
            get => _dependencies.GetValue();
            set => _dependencies.SetValue(value);
        }
    
        private PropertyValue<string?> _type = new PropertyValue<string?>(nameof(ContainerHelmChart), nameof(Type));
        
        [JsonPropertyName("type")]
        public string? Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _projectUrl.SetAccessPath(path, validateHasBeenSet);
            _sourceUrl.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _apiVersion.SetAccessPath(path, validateHasBeenSet);
            _appVersion.SetAccessPath(path, validateHasBeenSet);
            _dependencies.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
