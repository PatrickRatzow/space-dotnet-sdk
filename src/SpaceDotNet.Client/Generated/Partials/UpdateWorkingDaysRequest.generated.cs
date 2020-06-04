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

namespace SpaceDotNet.Client.UpdateWorkingDaysRequestExtensions
{
    public static class UpdateWorkingDaysRequestPartialExtensions
    {
        public static Partial<UpdateWorkingDaysRequest> WithProfile(this Partial<UpdateWorkingDaysRequest> it)    => it.AddFieldName("profile");
        
        public static Partial<UpdateWorkingDaysRequest> WithDateStart(this Partial<UpdateWorkingDaysRequest> it)    => it.AddFieldName("dateStart");
        
        public static Partial<UpdateWorkingDaysRequest> WithDateEnd(this Partial<UpdateWorkingDaysRequest> it)    => it.AddFieldName("dateEnd");
        
        public static Partial<UpdateWorkingDaysRequest> WithWorkingDaysSpec(this Partial<UpdateWorkingDaysRequest> it)    => it.AddFieldName("workingDaysSpec");
        
        public static Partial<UpdateWorkingDaysRequest> WithWorkingDaysSpec(this Partial<UpdateWorkingDaysRequest> it, Func<Partial<WorkingDaysSpecDto>, Partial<WorkingDaysSpecDto>> partialBuilder)    => it.AddFieldName("workingDaysSpec", partialBuilder(new Partial<WorkingDaysSpecDto>()));
        
    }
    
}