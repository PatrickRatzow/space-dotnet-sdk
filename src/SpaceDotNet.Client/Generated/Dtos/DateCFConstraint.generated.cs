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
    public sealed class DateCFConstraint
         : CFConstraint, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "DateCFConstraint";
        
        public DateCFConstraint() { }
        
        public DateCFConstraint(SpaceDate? min = null, SpaceDate? max = null, string? message = null)
        {
            Min = min;
            Max = max;
            Message = message;
        }
        
        private PropertyValue<SpaceDate?> _min = new PropertyValue<SpaceDate?>(nameof(DateCFConstraint), nameof(Min));
        
        [JsonPropertyName("min")]
        public SpaceDate? Min
        {
            get { return _min.GetValue(); }
            set { _min.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _max = new PropertyValue<SpaceDate?>(nameof(DateCFConstraint), nameof(Max));
        
        [JsonPropertyName("max")]
        public SpaceDate? Max
        {
            get { return _max.GetValue(); }
            set { _max.SetValue(value); }
        }
    
        private PropertyValue<string?> _message = new PropertyValue<string?>(nameof(DateCFConstraint), nameof(Message));
        
        [JsonPropertyName("message")]
        public string? Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _min.SetAccessPath(path, validateHasBeenSet);
            _max.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
