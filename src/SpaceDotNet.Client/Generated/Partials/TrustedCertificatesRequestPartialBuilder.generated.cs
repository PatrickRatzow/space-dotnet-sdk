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

namespace SpaceDotNet.Client.TrustedCertificatesRequestPartialBuilder
{
    public static class TrustedCertificatesRequestPartialExtensions
    {
        public static Partial<TrustedCertificatesRequest> WithAlias(this Partial<TrustedCertificatesRequest> it)
            => it.AddFieldName("alias");
        
        public static Partial<TrustedCertificatesRequest> WithData(this Partial<TrustedCertificatesRequest> it)
            => it.AddFieldName("data");
        
        public static Partial<TrustedCertificatesRequest> WithArchived(this Partial<TrustedCertificatesRequest> it)
            => it.AddFieldName("archived");
        
    }
    
}