// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5395596+00:00
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

namespace SpaceDotNet.Client.ApproveAbsenceRequestExtensions
{
    public static class ApproveAbsenceRequestDtoPartialExtensions
    {
        public static Partial<ApproveAbsenceRequestDto> WithApprove(this Partial<ApproveAbsenceRequestDto> it)
            => it.AddFieldName("approve");
        
    }
    
}
