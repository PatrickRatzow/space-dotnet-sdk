// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class KbPersonalContext
         : KBBookContext, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "KbPersonalContext";
        
        public KbPersonalContext() { }
        
        public KbPersonalContext(TDMemberProfile owner)
        {
            Owner = owner;
        }
        
        private PropertyValue<TDMemberProfile> _owner = new PropertyValue<TDMemberProfile>(nameof(KbPersonalContext), nameof(Owner));
        
        [Required]
        [JsonPropertyName("owner")]
        public TDMemberProfile Owner
        {
            get => _owner.GetValue();
            set => _owner.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _owner.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
