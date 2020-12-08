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
    public sealed class AttachmentInfo
         : IPropagatePropertyAccessPath
    {
        public AttachmentInfo() { }
        
        public AttachmentInfo(Attachment? details = null)
        {
            Details = details;
        }
        
        private PropertyValue<Attachment?> _details = new PropertyValue<Attachment?>(nameof(AttachmentInfo), nameof(Details));
        
        [JsonPropertyName("details")]
        public Attachment? Details
        {
            get => _details.GetValue();
            set => _details.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _details.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
