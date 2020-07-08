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
    public sealed class UnfurlsBlockListEntryDto
         : IPropagatePropertyAccessPath
    {
        public UnfurlsBlockListEntryDto() { }
        
        public UnfurlsBlockListEntryDto(string link, bool prefix, bool global)
        {
            Link = link;
            Prefix = prefix;
            Global = global;
        }
        
        private PropertyValue<string> _link = new PropertyValue<string>(nameof(UnfurlsBlockListEntryDto), nameof(Link));
        
        [Required]
        [JsonPropertyName("link")]
        public string Link
        {
            get { return _link.GetValue(); }
            set { _link.SetValue(value); }
        }
    
        private PropertyValue<bool> _prefix = new PropertyValue<bool>(nameof(UnfurlsBlockListEntryDto), nameof(Prefix));
        
        [Required]
        [JsonPropertyName("prefix")]
        public bool Prefix
        {
            get { return _prefix.GetValue(); }
            set { _prefix.SetValue(value); }
        }
    
        private PropertyValue<bool> _global = new PropertyValue<bool>(nameof(UnfurlsBlockListEntryDto), nameof(Global));
        
        [Required]
        [JsonPropertyName("global")]
        public bool Global
        {
            get { return _global.GetValue(); }
            set { _global.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _link.SetAccessPath(path, validateHasBeenSet);
            _prefix.SetAccessPath(path, validateHasBeenSet);
            _global.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
