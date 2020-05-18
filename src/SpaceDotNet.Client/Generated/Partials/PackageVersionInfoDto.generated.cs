// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.5090682+00:00
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

namespace SpaceDotNet.Client.PackageVersionInfoExtensions
{
    public static class PackageVersionInfoDtoPartialExtensions
    {
        public static Partial<PackageVersionInfoDto> WithType(this Partial<PackageVersionInfoDto> it)
            => it.AddFieldName("type");
        
        public static Partial<PackageVersionInfoDto> WithType(this Partial<PackageVersionInfoDto> it, Func<Partial<PackageTypeDto>, Partial<PackageTypeDto>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageTypeDto>()));
        
        public static Partial<PackageVersionInfoDto> WithRepository(this Partial<PackageVersionInfoDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<PackageVersionInfoDto> WithName(this Partial<PackageVersionInfoDto> it)
            => it.AddFieldName("name");
        
        public static Partial<PackageVersionInfoDto> WithVersion(this Partial<PackageVersionInfoDto> it)
            => it.AddFieldName("version");
        
        public static Partial<PackageVersionInfoDto> WithTags(this Partial<PackageVersionInfoDto> it)
            => it.AddFieldName("tags");
        
        public static Partial<PackageVersionInfoDto> WithTags(this Partial<PackageVersionInfoDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("tags", partialBuilder(new Partial<string>()));
        
    }
    
}
