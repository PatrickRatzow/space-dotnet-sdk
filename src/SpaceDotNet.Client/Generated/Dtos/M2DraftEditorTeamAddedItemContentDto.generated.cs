// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class M2DraftEditorTeamAddedItemContentDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2DraftEditorTeamAddedItemContent";
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2DraftEditorTeamAddedItemContentDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDTeamDto> _team = new PropertyValue<TDTeamDto>(nameof(M2DraftEditorTeamAddedItemContentDto), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeamDto Team
        {
            get { return _team.GetValue(); }
            set { _team.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(M2DraftEditorTeamAddedItemContentDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
