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
    public sealed class TeamAddedItemDetails
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "TeamAddedItemDetails";
        
        public TeamAddedItemDetails() { }
        
        public TeamAddedItemDetails(TDTeam team)
        {
            Team = team;
        }
        
        private PropertyValue<TDTeam> _team = new PropertyValue<TDTeam>(nameof(TeamAddedItemDetails), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeam Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _team.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
