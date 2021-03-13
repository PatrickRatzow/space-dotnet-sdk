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
    public sealed class ApplicationsSubscriptionFilter
         : SubscriptionFilter, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ApplicationsSubscriptionFilter";
        
        public ApplicationsSubscriptionFilter() { }
        
        public ApplicationsSubscriptionFilter(ESApp? application = null)
        {
            Application = application;
        }
        
        private PropertyValue<ESApp?> _application = new PropertyValue<ESApp?>(nameof(ApplicationsSubscriptionFilter), nameof(Application));
        
        [JsonPropertyName("application")]
        public ESApp? Application
        {
            get => _application.GetValue();
            set => _application.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _application.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
