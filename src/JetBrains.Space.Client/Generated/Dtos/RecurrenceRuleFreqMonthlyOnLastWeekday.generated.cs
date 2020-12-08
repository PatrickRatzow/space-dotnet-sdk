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
    public sealed class RecurrenceRuleFreqMonthlyOnLastWeekday
         : RecurrenceRuleFreq, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "RecurrenceRuleFreq.MonthlyOnLastWeekday";
        
        public RecurrenceRuleFreqMonthlyOnLastWeekday() { }
        
        public RecurrenceRuleFreqMonthlyOnLastWeekday(Weekday weekday, int interval)
        {
            Weekday = weekday;
            Interval = interval;
        }
        
        private PropertyValue<Weekday> _weekday = new PropertyValue<Weekday>(nameof(RecurrenceRuleFreqMonthlyOnLastWeekday), nameof(Weekday));
        
        [Required]
        [JsonPropertyName("weekday")]
        public Weekday Weekday
        {
            get => _weekday.GetValue();
            set => _weekday.SetValue(value);
        }
    
        private PropertyValue<int> _interval = new PropertyValue<int>(nameof(RecurrenceRuleFreqMonthlyOnLastWeekday), nameof(Interval));
        
        [Required]
        [JsonPropertyName("interval")]
        public int Interval
        {
            get => _interval.GetValue();
            set => _interval.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _weekday.SetAccessPath(path, validateHasBeenSet);
            _interval.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
