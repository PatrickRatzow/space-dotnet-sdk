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

namespace SpaceDotNet.Client.GitFileExtensions
{
    public static class GitFileDtoPartialExtensions
    {
        public static Partial<GitFileDto> WithCommit(this Partial<GitFileDto> it)
            => it.AddFieldName("commit");
        
        public static Partial<GitFileDto> WithPath(this Partial<GitFileDto> it)
            => it.AddFieldName("path");
        
        public static Partial<GitFileDto> WithBlob(this Partial<GitFileDto> it)
            => it.AddFieldName("blob");
        
        public static Partial<GitFileDto> WithType(this Partial<GitFileDto> it)
            => it.AddFieldName("type");
        
        public static Partial<GitFileDto> WithType(this Partial<GitFileDto> it, Func<Partial<GitEntryType>, Partial<GitEntryType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<GitEntryType>()));
        
    }
    
}
