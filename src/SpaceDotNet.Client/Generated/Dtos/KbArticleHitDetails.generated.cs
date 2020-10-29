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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class KbArticleHitDetails
         : EntityHitDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "KbArticleHitDetails";
        
        public KbArticleHitDetails() { }
        
        public KbArticleHitDetails(string id, KBBook bookRef, string contextName)
        {
            Id = id;
            BookRef = bookRef;
            ContextName = contextName;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KbArticleHitDetails), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<KBBook> _bookRef = new PropertyValue<KBBook>(nameof(KbArticleHitDetails), nameof(BookRef));
        
        [Required]
        [JsonPropertyName("bookRef")]
        public KBBook BookRef
        {
            get { return _bookRef.GetValue(); }
            set { _bookRef.SetValue(value); }
        }
    
        private PropertyValue<string> _contextName = new PropertyValue<string>(nameof(KbArticleHitDetails), nameof(ContextName));
        
        [Required]
        [JsonPropertyName("contextName")]
        public string ContextName
        {
            get { return _contextName.GetValue(); }
            set { _contextName.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _bookRef.SetAccessPath(path, validateHasBeenSet);
            _contextName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
