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
    public sealed class M2PackageCreatedDetails
         : M2PackageContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2PackageCreatedDetails";
        
        public M2PackageCreatedDetails() { }
        
        public M2PackageCreatedDetails(PackageVersionInfo pkg)
        {
            Pkg = pkg;
        }
        
        private PropertyValue<PackageVersionInfo> _pkg = new PropertyValue<PackageVersionInfo>(nameof(M2PackageCreatedDetails), nameof(Pkg));
        
        [Required]
        [JsonPropertyName("pkg")]
        public PackageVersionInfo Pkg
        {
            get => _pkg.GetValue();
            set => _pkg.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _pkg.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
