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
    public sealed class KbPersonalContextDto
         : KBBookContextDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "KbPersonalContext";
        
        private PropertyValue<TDMemberProfileDto> _owner = new PropertyValue<TDMemberProfileDto>(nameof(KbPersonalContextDto), nameof(Owner));
        
        [Required]
        [JsonPropertyName("owner")]
        public TDMemberProfileDto Owner
        {
            get { return _owner.GetValue(); }
            set { _owner.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _owner.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
