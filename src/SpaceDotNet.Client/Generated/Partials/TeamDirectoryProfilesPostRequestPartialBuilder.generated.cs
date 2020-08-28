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

namespace SpaceDotNet.Client.TeamDirectoryProfilesPostRequestPartialBuilder
{
    public static class TeamDirectoryProfilesPostRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesPostRequest> WithUsername(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("username");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithFirstName(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("firstName");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithLastName(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("lastName");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithEmails(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("emails");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithPhones(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("phones");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithBirthday(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("birthday");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithAbout(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("about");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithMessengers(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("messengers");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithLinks(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("links");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithIsNotAMember(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("notAMember");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithJoined(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("joined");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithLeft(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("left");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithIsSpeaksEnglish(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("speaksEnglish");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithPictureAttachmentId(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("pictureAttachmentId");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithAvatarCropSquare(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("avatarCropSquare");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithAvatarCropSquare(this Partial<TeamDirectoryProfilesPostRequest> it, Func<Partial<AvatarCropSquare>, Partial<AvatarCropSquare>> partialBuilder)
            => it.AddFieldName("avatarCropSquare", partialBuilder(new Partial<AvatarCropSquare>(it)));
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithCustomFieldValues(this Partial<TeamDirectoryProfilesPostRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<TeamDirectoryProfilesPostRequest> WithCustomFieldValues(this Partial<TeamDirectoryProfilesPostRequest> it, Func<Partial<CustomFieldValue>, Partial<CustomFieldValue>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValue>(it)));
        
    }
    
}
