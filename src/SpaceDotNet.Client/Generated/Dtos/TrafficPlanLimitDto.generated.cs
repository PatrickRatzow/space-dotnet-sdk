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
    public sealed class TrafficPlanLimitDto
         : IPropagatePropertyAccessPath
    {
        public TrafficPlanLimitDto() { }
        
        public TrafficPlanLimitDto(PlanLimitDto files, PlanLimitDto packages, PlanLimitDto git)
        {
            Files = files;
            Packages = packages;
            Git = git;
        }
        
        private PropertyValue<PlanLimitDto> _files = new PropertyValue<PlanLimitDto>(nameof(TrafficPlanLimitDto), nameof(Files));
        
        [Required]
        [JsonPropertyName("files")]
        public PlanLimitDto Files
        {
            get { return _files.GetValue(); }
            set { _files.SetValue(value); }
        }
    
        private PropertyValue<PlanLimitDto> _packages = new PropertyValue<PlanLimitDto>(nameof(TrafficPlanLimitDto), nameof(Packages));
        
        [Required]
        [JsonPropertyName("packages")]
        public PlanLimitDto Packages
        {
            get { return _packages.GetValue(); }
            set { _packages.SetValue(value); }
        }
    
        private PropertyValue<PlanLimitDto> _git = new PropertyValue<PlanLimitDto>(nameof(TrafficPlanLimitDto), nameof(Git));
        
        [Required]
        [JsonPropertyName("git")]
        public PlanLimitDto Git
        {
            get { return _git.GetValue(); }
            set { _git.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _files.SetAccessPath(path, validateHasBeenSet);
            _packages.SetAccessPath(path, validateHasBeenSet);
            _git.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
