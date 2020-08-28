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
    public sealed class ReactionTypeRecord
         : IPropagatePropertyAccessPath
    {
        public ReactionTypeRecord() { }
        
        public ReactionTypeRecord(string id, bool archived, ReactionData data, CPrincipal provider, SpaceDate addedAt, int? order = null)
        {
            Id = id;
            IsArchived = archived;
            Data = data;
            Provider = provider;
            AddedAt = addedAt;
            Order = order;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ReactionTypeRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ReactionTypeRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<ReactionData> _data = new PropertyValue<ReactionData>(nameof(ReactionTypeRecord), nameof(Data));
        
        [Required]
        [JsonPropertyName("data")]
        public ReactionData Data
        {
            get { return _data.GetValue(); }
            set { _data.SetValue(value); }
        }
    
        private PropertyValue<CPrincipal> _provider = new PropertyValue<CPrincipal>(nameof(ReactionTypeRecord), nameof(Provider));
        
        [Required]
        [JsonPropertyName("provider")]
        public CPrincipal Provider
        {
            get { return _provider.GetValue(); }
            set { _provider.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _addedAt = new PropertyValue<SpaceDate>(nameof(ReactionTypeRecord), nameof(AddedAt));
        
        [Required]
        [JsonPropertyName("addedAt")]
        public SpaceDate AddedAt
        {
            get { return _addedAt.GetValue(); }
            set { _addedAt.SetValue(value); }
        }
    
        private PropertyValue<int?> _order = new PropertyValue<int?>(nameof(ReactionTypeRecord), nameof(Order));
        
        [JsonPropertyName("order")]
        public int? Order
        {
            get { return _order.GetValue(); }
            set { _order.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _data.SetAccessPath(path, validateHasBeenSet);
            _provider.SetAccessPath(path, validateHasBeenSet);
            _addedAt.SetAccessPath(path, validateHasBeenSet);
            _order.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
