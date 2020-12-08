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
    public sealed class TimeInterval
         : IPropagatePropertyAccessPath
    {
        public TimeInterval() { }
        
        public TimeInterval(TimeOfDay since, TimeOfDay till)
        {
            Since = since;
            Till = till;
        }
        
        private PropertyValue<TimeOfDay> _since = new PropertyValue<TimeOfDay>(nameof(TimeInterval), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        public TimeOfDay Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<TimeOfDay> _till = new PropertyValue<TimeOfDay>(nameof(TimeInterval), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        public TimeOfDay Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
