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

namespace SpaceDotNet.Client.PackageRepositorySettingsExtensions
{
    public static class PackageRepositorySettingsDtoPartialExtensions
    {
        public static Partial<PackageRepositorySettingsDto> WithId(this Partial<PackageRepositorySettingsDto> it)
            => it.AddFieldName("id");
        
        public static Partial<PackageRepositorySettingsDto> WithName(this Partial<PackageRepositorySettingsDto> it)
            => it.AddFieldName("name");
        
        public static Partial<PackageRepositorySettingsDto> WithSettings(this Partial<PackageRepositorySettingsDto> it)
            => it.AddFieldName("settings");
        
        public static Partial<PackageRepositorySettingsDto> WithSettings(this Partial<PackageRepositorySettingsDto> it, Func<Partial<ESPackageRepositorySettingsDto>, Partial<ESPackageRepositorySettingsDto>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESPackageRepositorySettingsDto>()));
        
        public static Partial<PackageRepositorySettingsDto> WithPermissions(this Partial<PackageRepositorySettingsDto> it)
            => it.AddFieldName("permissions");
        
        public static Partial<PackageRepositorySettingsDto> WithPermissions(this Partial<PackageRepositorySettingsDto> it, Func<Partial<PackagesPermission>, Partial<PackagesPermission>> partialBuilder)
            => it.AddFieldName("permissions", partialBuilder(new Partial<PackagesPermission>()));
        
    }
    
}
