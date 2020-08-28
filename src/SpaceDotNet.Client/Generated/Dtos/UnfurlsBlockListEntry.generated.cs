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
    public sealed class UnfurlsBlockListEntry
         : IPropagatePropertyAccessPath
    {
        public UnfurlsBlockListEntry() { }
        
        public UnfurlsBlockListEntry(string link, bool prefix, bool global)
        {
            Link = link;
            IsPrefix = prefix;
            IsGlobal = global;
        }
        
        private PropertyValue<string> _link = new PropertyValue<string>(nameof(UnfurlsBlockListEntry), nameof(Link));
        
        [Required]
        [JsonPropertyName("link")]
        public string Link
        {
            get { return _link.GetValue(); }
            set { _link.SetValue(value); }
        }
    
        private PropertyValue<bool> _prefix = new PropertyValue<bool>(nameof(UnfurlsBlockListEntry), nameof(IsPrefix));
        
        [Required]
        [JsonPropertyName("prefix")]
        public bool IsPrefix
        {
            get { return _prefix.GetValue(); }
            set { _prefix.SetValue(value); }
        }
    
        private PropertyValue<bool> _global = new PropertyValue<bool>(nameof(UnfurlsBlockListEntry), nameof(IsGlobal));
        
        [Required]
        [JsonPropertyName("global")]
        public bool IsGlobal
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
