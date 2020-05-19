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

namespace SpaceDotNet.Client.DraftPublicationDetailsExtensions
{
    public static class DraftPublicationDetailsDtoPartialExtensions
    {
        public static Partial<DraftPublicationDetailsDto> WithUsedType(this Partial<DraftPublicationDetailsDto> it)
            => it.AddFieldName("usedType");
        
        public static Partial<DraftPublicationDetailsDto> WithAllPublicationDetails(this Partial<DraftPublicationDetailsDto> it)
            => it.AddFieldName("allPublicationDetails");
        
        public static Partial<DraftPublicationDetailsDto> WithAllPublicationDetails(this Partial<DraftPublicationDetailsDto> it, Func<Partial<PublicationDetailsDto>, Partial<PublicationDetailsDto>> partialBuilder)
            => it.AddFieldName("allPublicationDetails", partialBuilder(new Partial<PublicationDetailsDto>()));
        
    }
    
}