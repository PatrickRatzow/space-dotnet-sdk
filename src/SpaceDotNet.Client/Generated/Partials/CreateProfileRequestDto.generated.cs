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

namespace SpaceDotNet.Client.CreateProfileRequestExtensions
{
    public static class CreateProfileRequestDtoPartialExtensions
    {
        public static Partial<CreateProfileRequestDto> WithUsername(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("username");
        
        public static Partial<CreateProfileRequestDto> WithFirstName(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("firstName");
        
        public static Partial<CreateProfileRequestDto> WithLastName(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("lastName");
        
        public static Partial<CreateProfileRequestDto> WithEmails(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("emails");
        
        public static Partial<CreateProfileRequestDto> WithPhones(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("phones");
        
        public static Partial<CreateProfileRequestDto> WithBirthday(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("birthday");
        
        public static Partial<CreateProfileRequestDto> WithAbout(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("about");
        
        public static Partial<CreateProfileRequestDto> WithGender(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("gender");
        
        public static Partial<CreateProfileRequestDto> WithGender(this Partial<CreateProfileRequestDto> it, Func<Partial<Gender>, Partial<Gender>> partialBuilder)
            => it.AddFieldName("gender", partialBuilder(new Partial<Gender>()));
        
        public static Partial<CreateProfileRequestDto> WithMessengers(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("messengers");
        
        public static Partial<CreateProfileRequestDto> WithLinks(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("links");
        
        public static Partial<CreateProfileRequestDto> WithNotAMember(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("notAMember");
        
        public static Partial<CreateProfileRequestDto> WithJoined(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("joined");
        
        public static Partial<CreateProfileRequestDto> WithLeft(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("left");
        
        public static Partial<CreateProfileRequestDto> WithSpeaksEnglish(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("speaksEnglish");
        
        public static Partial<CreateProfileRequestDto> WithPictureAttachmentId(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("pictureAttachmentId");
        
        public static Partial<CreateProfileRequestDto> WithAvatarCropSquare(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("avatarCropSquare");
        
        public static Partial<CreateProfileRequestDto> WithAvatarCropSquare(this Partial<CreateProfileRequestDto> it, Func<Partial<AvatarCropSquareDto>, Partial<AvatarCropSquareDto>> partialBuilder)
            => it.AddFieldName("avatarCropSquare", partialBuilder(new Partial<AvatarCropSquareDto>()));
        
        public static Partial<CreateProfileRequestDto> WithCustomFieldValues(this Partial<CreateProfileRequestDto> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<CreateProfileRequestDto> WithCustomFieldValues(this Partial<CreateProfileRequestDto> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValueDto>()));
        
    }
    
}
