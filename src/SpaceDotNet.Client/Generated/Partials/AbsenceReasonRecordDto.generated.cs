// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.4332431+00:00
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

namespace SpaceDotNet.Client.AbsenceReasonRecordExtensions
{
    public static class AbsenceReasonRecordDtoPartialExtensions
    {
        public static Partial<AbsenceReasonRecordDto> WithId(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<AbsenceReasonRecordDto> WithArchived(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<AbsenceReasonRecordDto> WithName(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("name");
        
        public static Partial<AbsenceReasonRecordDto> WithDescription(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsenceReasonRecordDto> WithDefaultAvailability(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("defaultAvailability");
        
        public static Partial<AbsenceReasonRecordDto> WithApprovalRequired(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("approvalRequired");
        
        public static Partial<AbsenceReasonRecordDto> WithIcon(this Partial<AbsenceReasonRecordDto> it)
            => it.AddFieldName("icon");
        
    }
    
}
