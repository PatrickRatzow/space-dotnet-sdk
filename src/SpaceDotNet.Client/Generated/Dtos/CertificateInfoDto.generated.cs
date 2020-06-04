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

namespace SpaceDotNet.Client
{
    public sealed class CertificateInfoDto
    {
        [Required]
        [JsonPropertyName("certificateType")]
        public string CertificateType { get; set; }
    
        [Required]
        [JsonPropertyName("version")]
        public int Version { get; set; }
    
        [Required]
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
        [Required]
        [JsonPropertyName("issuedBy")]
        public string IssuedBy { get; set; }
    
        [Required]
        [JsonPropertyName("issuedTo")]
        public string IssuedTo { get; set; }
    
        [Required]
        [JsonPropertyName("validFrom")]
        public SpaceTime ValidFrom { get; set; }
    
        [Required]
        [JsonPropertyName("validTo")]
        public SpaceTime ValidTo { get; set; }
    
        [Required]
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }
    
        [Required]
        [JsonPropertyName("fingerprint")]
        public FingerprintDto Fingerprint { get; set; }
    
    }
    
}
