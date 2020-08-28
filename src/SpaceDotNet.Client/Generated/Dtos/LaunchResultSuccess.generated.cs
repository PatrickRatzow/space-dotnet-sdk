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
    public sealed class LaunchResultSuccess
         : LaunchResult, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "LaunchResult.Success";
        
        public LaunchResultSuccess() { }
        
        public LaunchResultSuccess(string executionId)
        {
            ExecutionId = executionId;
        }
        
        private PropertyValue<string> _executionId = new PropertyValue<string>(nameof(LaunchResultSuccess), nameof(ExecutionId));
        
        [Required]
        [JsonPropertyName("executionId")]
        public string ExecutionId
        {
            get { return _executionId.GetValue(); }
            set { _executionId.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _executionId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
