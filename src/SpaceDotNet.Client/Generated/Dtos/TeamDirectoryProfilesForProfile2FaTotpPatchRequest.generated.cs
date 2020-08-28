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
    public class TeamDirectoryProfilesForProfile2FaTotpPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfile2FaTotpPatchRequest() { }
        
        public TeamDirectoryProfilesForProfile2FaTotpPatchRequest(bool enabled)
        {
            IsEnabled = enabled;
        }
        
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(TeamDirectoryProfilesForProfile2FaTotpPatchRequest), nameof(IsEnabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool IsEnabled
        {
            get { return _enabled.GetValue(); }
            set { _enabled.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _enabled.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
