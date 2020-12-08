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
    public class AuthModulesForIdSamlMetadataPostRequest
         : IPropagatePropertyAccessPath
    {
        public AuthModulesForIdSamlMetadataPostRequest() { }
        
        public AuthModulesForIdSamlMetadataPostRequest(string idpUrl, string idpEntityId, string idpCertificateSHA256, string spEntityId, SSLKeystore? sslKeystore = null, string? contactProfileId = null)
        {
            IdpUrl = idpUrl;
            IdpEntityId = idpEntityId;
            IdpCertificateSHA256 = idpCertificateSHA256;
            SpEntityId = spEntityId;
            SslKeystore = sslKeystore;
            ContactProfileId = contactProfileId;
        }
        
        private PropertyValue<string> _idpUrl = new PropertyValue<string>(nameof(AuthModulesForIdSamlMetadataPostRequest), nameof(IdpUrl));
        
        [Required]
        [JsonPropertyName("idpUrl")]
        public string IdpUrl
        {
            get => _idpUrl.GetValue();
            set => _idpUrl.SetValue(value);
        }
    
        private PropertyValue<string> _idpEntityId = new PropertyValue<string>(nameof(AuthModulesForIdSamlMetadataPostRequest), nameof(IdpEntityId));
        
        [Required]
        [JsonPropertyName("idpEntityId")]
        public string IdpEntityId
        {
            get => _idpEntityId.GetValue();
            set => _idpEntityId.SetValue(value);
        }
    
        private PropertyValue<string> _idpCertificateSHA256 = new PropertyValue<string>(nameof(AuthModulesForIdSamlMetadataPostRequest), nameof(IdpCertificateSHA256));
        
        [Required]
        [JsonPropertyName("idpCertificateSHA256")]
        public string IdpCertificateSHA256
        {
            get => _idpCertificateSHA256.GetValue();
            set => _idpCertificateSHA256.SetValue(value);
        }
    
        private PropertyValue<string> _spEntityId = new PropertyValue<string>(nameof(AuthModulesForIdSamlMetadataPostRequest), nameof(SpEntityId));
        
        [Required]
        [JsonPropertyName("spEntityId")]
        public string SpEntityId
        {
            get => _spEntityId.GetValue();
            set => _spEntityId.SetValue(value);
        }
    
        private PropertyValue<SSLKeystore?> _sslKeystore = new PropertyValue<SSLKeystore?>(nameof(AuthModulesForIdSamlMetadataPostRequest), nameof(SslKeystore));
        
        [JsonPropertyName("sslKeystore")]
        public SSLKeystore? SslKeystore
        {
            get => _sslKeystore.GetValue();
            set => _sslKeystore.SetValue(value);
        }
    
        private PropertyValue<string?> _contactProfileId = new PropertyValue<string?>(nameof(AuthModulesForIdSamlMetadataPostRequest), nameof(ContactProfileId));
        
        [JsonPropertyName("contactProfileId")]
        public string? ContactProfileId
        {
            get => _contactProfileId.GetValue();
            set => _contactProfileId.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _idpUrl.SetAccessPath(path, validateHasBeenSet);
            _idpEntityId.SetAccessPath(path, validateHasBeenSet);
            _idpCertificateSHA256.SetAccessPath(path, validateHasBeenSet);
            _spEntityId.SetAccessPath(path, validateHasBeenSet);
            _sslKeystore.SetAccessPath(path, validateHasBeenSet);
            _contactProfileId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
