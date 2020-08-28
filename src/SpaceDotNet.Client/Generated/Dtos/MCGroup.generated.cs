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
    public sealed class MCGroup
         : MCElementDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCGroup";
        
        public MCGroup() { }
        
        public MCGroup(List<MCElement> elements)
        {
            Elements = elements;
        }
        
        private PropertyValue<List<MCElement>> _elements = new PropertyValue<List<MCElement>>(nameof(MCGroup), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<MCElement> Elements
        {
            get { return _elements.GetValue(); }
            set { _elements.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _elements.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
