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
    public sealed class M2ChannelContact
         : IPropagatePropertyAccessPath
    {
        public M2ChannelContact() { }
        
        public M2ChannelContact(string defaultName, string key, M2ChannelContactInfo? ext = null)
        {
            DefaultName = defaultName;
            Key = key;
            Ext = ext;
        }
        
        private PropertyValue<string> _defaultName = new PropertyValue<string>(nameof(M2ChannelContact), nameof(DefaultName));
        
        [Required]
        [JsonPropertyName("defaultName")]
        public string DefaultName
        {
            get => _defaultName.GetValue();
            set => _defaultName.SetValue(value);
        }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(M2ChannelContact), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<M2ChannelContactInfo?> _ext = new PropertyValue<M2ChannelContactInfo?>(nameof(M2ChannelContact), nameof(Ext));
        
        [JsonPropertyName("ext")]
        public M2ChannelContactInfo? Ext
        {
            get => _ext.GetValue();
            set => _ext.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _defaultName.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _ext.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
