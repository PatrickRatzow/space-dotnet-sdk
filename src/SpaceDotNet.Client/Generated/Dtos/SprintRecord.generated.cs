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
    public sealed class SprintRecord
         : IPropagatePropertyAccessPath
    {
        public SprintRecord() { }
        
        public SprintRecord(string id, bool archived, BoardRecord board, string name, SprintState state, SpaceDate from, SpaceDate to, bool @default, string? description = null)
        {
            Id = id;
            IsArchived = archived;
            Board = board;
            Name = name;
            State = state;
            From = from;
            To = to;
            IsDefault = @default;
            Description = description;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(SprintRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(SprintRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<BoardRecord> _board = new PropertyValue<BoardRecord>(nameof(SprintRecord), nameof(Board));
        
        [Required]
        [JsonPropertyName("board")]
        public BoardRecord Board
        {
            get { return _board.GetValue(); }
            set { _board.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(SprintRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<SprintState> _state = new PropertyValue<SprintState>(nameof(SprintRecord), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public SprintState State
        {
            get { return _state.GetValue(); }
            set { _state.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _from = new PropertyValue<SpaceDate>(nameof(SprintRecord), nameof(From));
        
        [Required]
        [JsonPropertyName("from")]
        public SpaceDate From
        {
            get { return _from.GetValue(); }
            set { _from.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _to = new PropertyValue<SpaceDate>(nameof(SprintRecord), nameof(To));
        
        [Required]
        [JsonPropertyName("to")]
        public SpaceDate To
        {
            get { return _to.GetValue(); }
            set { _to.SetValue(value); }
        }
    
        private PropertyValue<bool> _default = new PropertyValue<bool>(nameof(SprintRecord), nameof(IsDefault));
        
        [Required]
        [JsonPropertyName("default")]
        public bool IsDefault
        {
            get { return _default.GetValue(); }
            set { _default.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(SprintRecord), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _board.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _state.SetAccessPath(path, validateHasBeenSet);
            _from.SetAccessPath(path, validateHasBeenSet);
            _to.SetAccessPath(path, validateHasBeenSet);
            _default.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
