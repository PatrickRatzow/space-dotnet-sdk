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
    public sealed class RecurrenceRuleEndsTotalCount
         : RecurrenceRuleEnds, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "RecurrenceRuleEnds.TotalCount";
        
        public RecurrenceRuleEndsTotalCount() { }
        
        public RecurrenceRuleEndsTotalCount(int count)
        {
            Count = count;
        }
        
        private PropertyValue<int> _count = new PropertyValue<int>(nameof(RecurrenceRuleEndsTotalCount), nameof(Count));
        
        [Required]
        [JsonPropertyName("count")]
        public int Count
        {
            get => _count.GetValue();
            set => _count.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _count.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
