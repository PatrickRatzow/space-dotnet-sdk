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
    public sealed class HATypeRef
         : HAType, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_Type.Ref";
        
        public HATypeRef() { }
        
        public HATypeRef(HADto dto, bool nullable)
        {
            Dto = dto;
            IsNullable = nullable;
        }
        
        private PropertyValue<HADto> _dto = new PropertyValue<HADto>(nameof(HATypeRef), nameof(Dto));
        
        [Required]
        [JsonPropertyName("dto")]
        public HADto Dto
        {
            get { return _dto.GetValue(); }
            set { _dto.SetValue(value); }
        }
    
        private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeRef), nameof(IsNullable));
        
        [Required]
        [JsonPropertyName("nullable")]
        public bool IsNullable
        {
            get { return _nullable.GetValue(); }
            set { _nullable.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _dto.SetAccessPath(path, validateHasBeenSet);
            _nullable.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
