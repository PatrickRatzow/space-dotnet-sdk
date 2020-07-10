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
    public class ProjectsForProjectAccessAdminsProfilesRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectAccessAdminsProfilesRequest() { }
        
        public ProjectsForProjectAccessAdminsProfilesRequest(ProfileIdentifier profile)
        {
            Profile = profile;
        }
        
        private PropertyValue<ProfileIdentifier> _profile = new PropertyValue<ProfileIdentifier>(nameof(ProjectsForProjectAccessAdminsProfilesRequest), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public ProfileIdentifier Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
