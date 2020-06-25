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
    public sealed class IntListCFValueDto
         : CFValueDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "IntListCFValue";
        
        private PropertyValue<List<int>> _values = new PropertyValue<List<int>>(nameof(IntListCFValueDto), nameof(Values));
        
        [Required]
        [JsonPropertyName("values")]
        public List<int> Values
        {
            get { return _values.GetValue(); }
            set { _values.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _values.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
