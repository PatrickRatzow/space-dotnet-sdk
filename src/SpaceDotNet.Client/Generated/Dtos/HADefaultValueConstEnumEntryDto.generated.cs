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
    public sealed class HADefaultValueConstEnumEntryDto
         : HADefaultValueConstDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_DefaultValue.Const.EnumEntry";
        
        public HADefaultValueConstEnumEntryDto() { }
        
        public HADefaultValueConstEnumEntryDto(string entryName)
        {
            EntryName = entryName;
        }
        
        private PropertyValue<string> _entryName = new PropertyValue<string>(nameof(HADefaultValueConstEnumEntryDto), nameof(EntryName));
        
        [Required]
        [JsonPropertyName("entryName")]
        public string EntryName
        {
            get { return _entryName.GetValue(); }
            set { _entryName.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _entryName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
