// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class HATypeArrayDto
         : HATypeDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_Type.Array";
        
        private PropertyValue<HATypeDto> _elementType = new PropertyValue<HATypeDto>(nameof(HATypeArrayDto), nameof(ElementType));
        
        [Required]
        [JsonPropertyName("elementType")]
        public HATypeDto ElementType
        {
            get { return _elementType.GetValue(); }
            set { _elementType.SetValue(value); }
        }
    
        private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeArrayDto), nameof(Nullable));
        
        [Required]
        [JsonPropertyName("nullable")]
        public bool Nullable
        {
            get { return _nullable.GetValue(); }
            set { _nullable.SetValue(value); }
        }
    
        private PropertyValue<bool> _optional = new PropertyValue<bool>(nameof(HATypeArrayDto), nameof(Optional));
        
        [Required]
        [JsonPropertyName("optional")]
        public bool Optional
        {
            get { return _optional.GetValue(); }
            set { _optional.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _elementType.SetAccessPath(path, validateHasBeenSet);
            _nullable.SetAccessPath(path, validateHasBeenSet);
            _optional.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
