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

namespace SpaceDotNet.Client.DraftPublicationDetailsPartialBuilder
{
    public static class DraftPublicationDetailsPartialExtensions
    {
        public static Partial<DraftPublicationDetails> WithUsedType(this Partial<DraftPublicationDetails> it)
            => it.AddFieldName("usedType");
        
        public static Partial<DraftPublicationDetails> WithAllPublicationDetails(this Partial<DraftPublicationDetails> it)
            => it.AddFieldName("allPublicationDetails");
        
        public static Partial<DraftPublicationDetails> WithAllPublicationDetails(this Partial<DraftPublicationDetails> it, Func<Partial<PublicationDetails>, Partial<PublicationDetails>> partialBuilder)
            => it.AddFieldName("allPublicationDetails", partialBuilder(new Partial<PublicationDetails>(it)));
        
    }
    
}
