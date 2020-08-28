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

namespace SpaceDotNet.Client.SyntaxMarkupPartialBuilder
{
    public static class SyntaxMarkupPartialExtensions
    {
        public static Partial<SyntaxMarkup> WithType(this Partial<SyntaxMarkup> it)
            => it.AddFieldName("type");
        
        public static Partial<SyntaxMarkup> WithType(this Partial<SyntaxMarkup> it, Func<Partial<SyntaxMarkupType>, Partial<SyntaxMarkupType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<SyntaxMarkupType>(it)));
        
        public static Partial<SyntaxMarkup> WithRange(this Partial<SyntaxMarkup> it)
            => it.AddFieldName("range");
        
        public static Partial<SyntaxMarkup> WithRange(this Partial<SyntaxMarkup> it, Func<Partial<TextRange>, Partial<TextRange>> partialBuilder)
            => it.AddFieldName("range", partialBuilder(new Partial<TextRange>(it)));
        
    }
    
}
