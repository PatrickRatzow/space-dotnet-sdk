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
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ProjectsPlanningBoardsSprintsPostRequestPartialBuilder
{
    public static class ProjectsPlanningBoardsSprintsPostRequestPartialExtensions
    {
        public static Partial<ProjectsPlanningBoardsSprintsPostRequest> WithBoard(this Partial<ProjectsPlanningBoardsSprintsPostRequest> it)
            => it.AddFieldName("board");
        
        public static Partial<ProjectsPlanningBoardsSprintsPostRequest> WithBoard(this Partial<ProjectsPlanningBoardsSprintsPostRequest> it, Func<Partial<BoardIdentifier>, Partial<BoardIdentifier>> partialBuilder)
            => it.AddFieldName("board", partialBuilder(new Partial<BoardIdentifier>(it)));
        
        public static Partial<ProjectsPlanningBoardsSprintsPostRequest> WithName(this Partial<ProjectsPlanningBoardsSprintsPostRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<ProjectsPlanningBoardsSprintsPostRequest> WithDescription(this Partial<ProjectsPlanningBoardsSprintsPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectsPlanningBoardsSprintsPostRequest> WithFrom(this Partial<ProjectsPlanningBoardsSprintsPostRequest> it)
            => it.AddFieldName("from");
        
        public static Partial<ProjectsPlanningBoardsSprintsPostRequest> WithTo(this Partial<ProjectsPlanningBoardsSprintsPostRequest> it)
            => it.AddFieldName("to");
        
    }
    
}