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

namespace SpaceDotNet.Client.TeamDirectoryProfilesForProfilePatchRequestPartialBuilder
{
    public static class TeamDirectoryProfilesForProfilePatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithUsername(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("username");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithFirstName(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("firstName");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithLastName(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("lastName");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithEmails(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("emails");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithPhones(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("phones");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithBirthday(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("birthday");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithAbout(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("about");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithMessengers(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("messengers");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithLinks(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("links");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithIsNotAMember(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("notAMember");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithJoined(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("joined");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithLeft(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("left");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithIsSpeaksEnglish(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("speaksEnglish");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithPictureAttachmentId(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("pictureAttachmentId");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithAvatarCropSquare(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("avatarCropSquare");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithAvatarCropSquare(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it, Func<Partial<AvatarCropSquare>, Partial<AvatarCropSquare>> partialBuilder)
            => it.AddFieldName("avatarCropSquare", partialBuilder(new Partial<AvatarCropSquare>(it)));
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<TeamDirectoryProfilesForProfilePatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryProfilesForProfilePatchRequest> it, Func<Partial<CustomFieldValue>, Partial<CustomFieldValue>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValue>(it)));
        
    }
    
}
