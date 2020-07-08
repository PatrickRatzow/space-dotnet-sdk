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

namespace SpaceDotNet.Client.ChatsMessagesSendMessageRequestPartialBuilder
{
    public static class ChatsMessagesSendMessageRequestPartialExtensions
    {
        public static Partial<ChatsMessagesSendMessageRequest> WithRecipient(this Partial<ChatsMessagesSendMessageRequest> it)
            => it.AddFieldName("recipient");
        
        public static Partial<ChatsMessagesSendMessageRequest> WithRecipient(this Partial<ChatsMessagesSendMessageRequest> it, Func<Partial<MessageRecipientDto>, Partial<MessageRecipientDto>> partialBuilder)
            => it.AddFieldName("recipient", partialBuilder(new Partial<MessageRecipientDto>(it)));
        
        public static Partial<ChatsMessagesSendMessageRequest> WithContent(this Partial<ChatsMessagesSendMessageRequest> it)
            => it.AddFieldName("content");
        
        public static Partial<ChatsMessagesSendMessageRequest> WithContent(this Partial<ChatsMessagesSendMessageRequest> it, Func<Partial<ChatMessageDto>, Partial<ChatMessageDto>> partialBuilder)
            => it.AddFieldName("content", partialBuilder(new Partial<ChatMessageDto>(it)));
        
        public static Partial<ChatsMessagesSendMessageRequest> WithUnfurlLinks(this Partial<ChatsMessagesSendMessageRequest> it)
            => it.AddFieldName("unfurlLinks");
        
        public static Partial<ChatsMessagesSendMessageRequest> WithAttachments(this Partial<ChatsMessagesSendMessageRequest> it)
            => it.AddFieldName("attachments");
        
        public static Partial<ChatsMessagesSendMessageRequest> WithAttachments(this Partial<ChatsMessagesSendMessageRequest> it, Func<Partial<AttachmentDto>, Partial<AttachmentDto>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentDto>(it)));
        
    }
    
}
