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
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _details.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
