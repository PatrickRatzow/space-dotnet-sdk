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

namespace SpaceDotNet.Client.ContainerImageAnnotationDtoPartialBuilder
{
    public static class ContainerImageAnnotationDtoPartialExtensions
    {
        public static Partial<ContainerImageAnnotationDto> WithCreated(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("created");
        
        public static Partial<ContainerImageAnnotationDto> WithBuildName(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("buildName");
        
        public static Partial<ContainerImageAnnotationDto> WithBuildUrl(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("buildUrl");
        
        public static Partial<ContainerImageAnnotationDto> WithRevision(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("revision");
        
        public static Partial<ContainerImageAnnotationDto> WithVendor(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("vendor");
        
        public static Partial<ContainerImageAnnotationDto> WithDocumentationUrl(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("documentationUrl");
        
        public static Partial<ContainerImageAnnotationDto> WithLicenses(this Partial<ContainerImageAnnotationDto> it)
            => it.AddFieldName("licenses");
        
    }
    
}