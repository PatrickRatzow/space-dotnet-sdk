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

namespace SpaceDotNet.Client.MembersAddedItemDetailsPartialBuilder
{
    public static class MembersAddedItemDetailsPartialExtensions
    {
        public static Partial<MembersAddedItemDetails> WithPrincipals(this Partial<MembersAddedItemDetails> it)
            => it.AddFieldName("principals");
        
        public static Partial<MembersAddedItemDetails> WithPrincipals(this Partial<MembersAddedItemDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("principals", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<MembersAddedItemDetails> WithOthersDisplayNames(this Partial<MembersAddedItemDetails> it)
            => it.AddFieldName("othersDisplayNames");
        
    }
    
}
