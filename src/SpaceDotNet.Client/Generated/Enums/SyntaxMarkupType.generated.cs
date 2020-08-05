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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class SyntaxMarkupType : Enumeration
    {
        private SyntaxMarkupType(string value) : base(value) { }
        
        public static readonly SyntaxMarkupType KEYWORD = new SyntaxMarkupType("KEYWORD");
        public static readonly SyntaxMarkupType COMMENT = new SyntaxMarkupType("COMMENT");
        public static readonly SyntaxMarkupType BOLDIDENTIFIER = new SyntaxMarkupType("BOLD_IDENTIFIER");
        public static readonly SyntaxMarkupType ITALICIDENTIFIER = new SyntaxMarkupType("ITALIC_IDENTIFIER");
        public static readonly SyntaxMarkupType IDENTIFIER = new SyntaxMarkupType("IDENTIFIER");
        public static readonly SyntaxMarkupType DECLARATION = new SyntaxMarkupType("DECLARATION");
        public static readonly SyntaxMarkupType PARAMETERASSIGNMENT = new SyntaxMarkupType("PARAMETER_ASSIGNMENT");
        public static readonly SyntaxMarkupType NUMLITERAL = new SyntaxMarkupType("NUM_LITERAL");
        public static readonly SyntaxMarkupType STRINGLITERAL = new SyntaxMarkupType("STRING_LITERAL");
        public static readonly SyntaxMarkupType ANNOTATION = new SyntaxMarkupType("ANNOTATION");
        public static readonly SyntaxMarkupType PREPROCESSORANNOTATION = new SyntaxMarkupType("PREPROCESSOR_ANNOTATION");
        public static readonly SyntaxMarkupType PREPROCESSORMESSAGE = new SyntaxMarkupType("PREPROCESSOR_MESSAGE");
        public static readonly SyntaxMarkupType HIGHLIGHT = new SyntaxMarkupType("HIGHLIGHT");
        public static readonly SyntaxMarkupType SKIP = new SyntaxMarkupType("SKIP");
    }
    
}
