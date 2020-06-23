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

namespace SpaceDotNet.Client.BoardColumnDtoExtensions
{
    public static class BoardColumnDtoPartialExtensions
    {
        public static Partial<BoardColumnDto> WithName(this Partial<BoardColumnDto> it)
            => it.AddFieldName("name");
        
        public static Partial<BoardColumnDto> WithStatuses(this Partial<BoardColumnDto> it)
            => it.AddFieldName("statuses");
        
        public static Partial<BoardColumnDto> WithStatuses(this Partial<BoardColumnDto> it, Func<Partial<IssueStatusDto>, Partial<IssueStatusDto>> partialBuilder)
            => it.AddFieldName("statuses", partialBuilder(new Partial<IssueStatusDto>(it)));
        
        public static Partial<BoardColumnDto> WithDefault(this Partial<BoardColumnDto> it)
            => it.AddFieldName("default");
        
    }
    
}