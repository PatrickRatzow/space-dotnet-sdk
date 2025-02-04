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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class ExternalEndpoint
         : IPropagatePropertyAccessPath
    {
        public ExternalEndpoint() { }
        
        public ExternalEndpoint(bool sslVerification, string? url = null)
        {
            Url = url;
            IsSslVerification = sslVerification;
        }
        
        private PropertyValue<string?> _url = new PropertyValue<string?>(nameof(ExternalEndpoint), nameof(Url));
        
        [JsonPropertyName("url")]
        public string? Url
        {
            get => _url.GetValue();
            set => _url.SetValue(value);
        }
    
        private PropertyValue<bool> _sslVerification = new PropertyValue<bool>(nameof(ExternalEndpoint), nameof(IsSslVerification));
        
        [Required]
        [JsonPropertyName("sslVerification")]
        public bool IsSslVerification
        {
            get => _sslVerification.GetValue();
            set => _sslVerification.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _url.SetAccessPath(path, validateHasBeenSet);
            _sslVerification.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
