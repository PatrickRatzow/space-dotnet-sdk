// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4412923+00:00
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

namespace SpaceDotNet.Client.CertainReactionToItemRecordExtensions
{
    public static class CertainReactionToItemRecordDtoPartialExtensions
    {
        public static Partial<CertainReactionToItemRecordDto> WithId(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<CertainReactionToItemRecordDto> WithItemId(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("itemId");
        
        public static Partial<CertainReactionToItemRecordDto> WithReaction(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("reaction");
        
        public static Partial<CertainReactionToItemRecordDto> WithReaction(this Partial<CertainReactionToItemRecordDto> it, Func<Partial<ReactionTypeRecordDto>, Partial<ReactionTypeRecordDto>> partialBuilder)
            => it.AddFieldName("reaction", partialBuilder(new Partial<ReactionTypeRecordDto>()));
        
        public static Partial<CertainReactionToItemRecordDto> WithCount(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("count");
        
        public static Partial<CertainReactionToItemRecordDto> WithMeReacted(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("meReacted");
        
        public static Partial<CertainReactionToItemRecordDto> WithPrincipals(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("principals");
        
        public static Partial<CertainReactionToItemRecordDto> WithPrincipals(this Partial<CertainReactionToItemRecordDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("principals", partialBuilder(new Partial<CPrincipalDto>()));
        
        public static Partial<CertainReactionToItemRecordDto> WithOrder(this Partial<CertainReactionToItemRecordDto> it)
            => it.AddFieldName("order");
        
    }
    
}
