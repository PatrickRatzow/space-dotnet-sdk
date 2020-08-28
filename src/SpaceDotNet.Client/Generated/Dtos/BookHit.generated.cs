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
    public sealed class BookHit
         : EntityHit, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "BookHit";
        
        public BookHit() { }
        
        public BookHit(string id, double score, KBBook @ref, string title, string summary)
        {
            Id = id;
            Score = score;
            Ref = @ref;
            Title = title;
            Summary = summary;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(BookHit), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(BookHit), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score
        {
            get { return _score.GetValue(); }
            set { _score.SetValue(value); }
        }
    
        private PropertyValue<KBBook> _ref = new PropertyValue<KBBook>(nameof(BookHit), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public KBBook Ref
        {
            get { return _ref.GetValue(); }
            set { _ref.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(BookHit), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(BookHit), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get { return _summary.GetValue(); }
            set { _summary.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _score.SetAccessPath(path, validateHasBeenSet);
            _ref.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _summary.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
