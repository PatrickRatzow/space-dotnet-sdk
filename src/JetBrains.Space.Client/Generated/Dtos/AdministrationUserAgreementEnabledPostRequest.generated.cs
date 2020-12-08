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
    public class AdministrationUserAgreementEnabledPostRequest
         : IPropagatePropertyAccessPath
    {
        public AdministrationUserAgreementEnabledPostRequest() { }
        
        public AdministrationUserAgreementEnabledPostRequest(bool enabled)
        {
            IsEnabled = enabled;
        }
        
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(AdministrationUserAgreementEnabledPostRequest), nameof(IsEnabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool IsEnabled
        {
            get => _enabled.GetValue();
            set => _enabled.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _enabled.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
