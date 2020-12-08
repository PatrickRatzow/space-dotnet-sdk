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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class HAType
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "HA_Type";
        
        public static HATypeArray Array(HAType elementType, bool nullable)
            => new HATypeArray(elementType: elementType, nullable: nullable);
        
        public static HATypeDto Dto(HADto dto, bool nullable)
            => new HATypeDto(dto: dto, nullable: nullable);
        
        public static HATypeEnum Enum(HAEnum @enum, bool nullable)
            => new HATypeEnum(@enum: @enum, nullable: nullable);
        
        public static HATypeMap Map(HAType valueType, bool nullable)
            => new HATypeMap(valueType: valueType, nullable: nullable);
        
        public static HATypeObject Object(List<HAField> fields, HATypeObjectKind kind, bool nullable)
            => new HATypeObject(fields: fields, kind: kind, nullable: nullable);
        
        public static HATypePrimitive Primitive(HAPrimitive primitive, bool nullable)
            => new HATypePrimitive(primitive: primitive, nullable: nullable);
        
        public static HATypeRef Ref(HADto dto, bool nullable)
            => new HATypeRef(dto: dto, nullable: nullable);
        
        public static HATypeUrlParam UrlParam(HAUrlParameter urlParam, bool nullable)
            => new HATypeUrlParam(urlParam: urlParam, nullable: nullable);
        
        public HAType() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
