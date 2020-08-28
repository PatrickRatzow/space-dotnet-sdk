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
    public sealed class Estimation
         : IPropagatePropertyAccessPath
    {
        public Estimation() { }
        
        public Estimation(SpaceTime start, long predictedDuration)
        {
            Start = start;
            PredictedDuration = predictedDuration;
        }
        
        private PropertyValue<SpaceTime> _start = new PropertyValue<SpaceTime>(nameof(Estimation), nameof(Start));
        
        [Required]
        [JsonPropertyName("start")]
        public SpaceTime Start
        {
            get { return _start.GetValue(); }
            set { _start.SetValue(value); }
        }
    
        private PropertyValue<long> _predictedDuration = new PropertyValue<long>(nameof(Estimation), nameof(PredictedDuration));
        
        [Required]
        [JsonPropertyName("predictedDuration")]
        public long PredictedDuration
        {
            get { return _predictedDuration.GetValue(); }
            set { _predictedDuration.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _start.SetAccessPath(path, validateHasBeenSet);
            _predictedDuration.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
