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
    public class DocsDraftsForIdEditorsTeamsPostRequest
         : IPropagatePropertyAccessPath
    {
        public DocsDraftsForIdEditorsTeamsPostRequest() { }
        
        public DocsDraftsForIdEditorsTeamsPostRequest(string teamId)
        {
            TeamId = teamId;
        }
        
        private PropertyValue<string> _teamId = new PropertyValue<string>(nameof(DocsDraftsForIdEditorsTeamsPostRequest), nameof(TeamId));
        
        [Required]
        [JsonPropertyName("teamId")]
        public string TeamId
        {
            get => _teamId.GetValue();
            set => _teamId.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _teamId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
