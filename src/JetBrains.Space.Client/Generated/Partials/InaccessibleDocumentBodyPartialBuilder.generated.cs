// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.InaccessibleDocumentBodyPartialBuilder
{
    public static class InaccessibleDocumentBodyPartialExtensions
    {
        public static Partial<InaccessibleDocumentBody> WithDocBodyType(this Partial<InaccessibleDocumentBody> it)
            => it.AddFieldName("docBodyType");
        
        public static Partial<InaccessibleDocumentBody> WithDocBodyType(this Partial<InaccessibleDocumentBody> it, Func<Partial<DocumentBodyType>, Partial<DocumentBodyType>> partialBuilder)
            => it.AddFieldName("docBodyType", partialBuilder(new Partial<DocumentBodyType>(it)));
        
        public static Partial<InaccessibleDocumentBody> WithDocBodyId(this Partial<InaccessibleDocumentBody> it)
            => it.AddFieldName("docBodyId");
        
    }
    
}
