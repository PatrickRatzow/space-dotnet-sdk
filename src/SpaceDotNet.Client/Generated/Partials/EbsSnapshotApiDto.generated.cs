// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4675318+00:00
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

namespace SpaceDotNet.Client.EbsSnapshotApiExtensions
{
    public static class EbsSnapshotApiDtoPartialExtensions
    {
        public static Partial<EbsSnapshotApiDto> WithSnapshotId(this Partial<EbsSnapshotApiDto> it)
            => it.AddFieldName("snapshotId");
        
        public static Partial<EbsSnapshotApiDto> WithSnapshotState(this Partial<EbsSnapshotApiDto> it)
            => it.AddFieldName("snapshotState");
        
        public static Partial<EbsSnapshotApiDto> WithExecution(this Partial<EbsSnapshotApiDto> it)
            => it.AddFieldName("execution");
        
    }
    
}
