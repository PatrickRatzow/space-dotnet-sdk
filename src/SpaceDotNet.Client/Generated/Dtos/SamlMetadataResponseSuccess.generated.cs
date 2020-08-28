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
    public sealed class SamlMetadataResponseSuccess
         : SamlMetadataResponse, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "SamlMetadataResponse.Success";
        
        public SamlMetadataResponseSuccess() { }
        
        public SamlMetadataResponseSuccess(string metadata)
        {
            Metadata = metadata;
        }
        
        private PropertyValue<string> _metadata = new PropertyValue<string>(nameof(SamlMetadataResponseSuccess), nameof(Metadata));
        
        [Required]
        [JsonPropertyName("metadata")]
        public string Metadata
        {
            get { return _metadata.GetValue(); }
            set { _metadata.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _metadata.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
