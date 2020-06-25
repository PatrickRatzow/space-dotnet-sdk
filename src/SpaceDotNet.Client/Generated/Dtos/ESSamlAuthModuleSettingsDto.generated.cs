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
    public sealed class ESSamlAuthModuleSettingsDto
         : ESFederatedAuthModuleSettingsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_SamlAuthModuleSettings";
        
        private PropertyValue<string> _idpUrl = new PropertyValue<string>(nameof(ESSamlAuthModuleSettingsDto), nameof(IdpUrl));
        
        [Required]
        [JsonPropertyName("idpUrl")]
        public string IdpUrl
        {
            get { return _idpUrl.GetValue(); }
            set { _idpUrl.SetValue(value); }
        }
    
        private PropertyValue<string> _idpEntityId = new PropertyValue<string>(nameof(ESSamlAuthModuleSettingsDto), nameof(IdpEntityId));
        
        [Required]
        [JsonPropertyName("idpEntityId")]
        public string IdpEntityId
        {
            get { return _idpEntityId.GetValue(); }
            set { _idpEntityId.SetValue(value); }
        }
    
        private PropertyValue<string> _idpCertificateSHA256 = new PropertyValue<string>(nameof(ESSamlAuthModuleSettingsDto), nameof(IdpCertificateSHA256));
        
        [Required]
        [JsonPropertyName("idpCertificateSHA256")]
        public string IdpCertificateSHA256
        {
            get { return _idpCertificateSHA256.GetValue(); }
            set { _idpCertificateSHA256.SetValue(value); }
        }
    
        private PropertyValue<string> _spEntityId = new PropertyValue<string>(nameof(ESSamlAuthModuleSettingsDto), nameof(SpEntityId));
        
        [Required]
        [JsonPropertyName("spEntityId")]
        public string SpEntityId
        {
            get { return _spEntityId.GetValue(); }
            set { _spEntityId.SetValue(value); }
        }
    
        private PropertyValue<SSLKeystoreDto?> _sslKeystore = new PropertyValue<SSLKeystoreDto?>(nameof(ESSamlAuthModuleSettingsDto), nameof(SslKeystore));
        
        [JsonPropertyName("sslKeystore")]
        public SSLKeystoreDto? SslKeystore
        {
            get { return _sslKeystore.GetValue(); }
            set { _sslKeystore.SetValue(value); }
        }
    
        private PropertyValue<bool> _registerNewUsers = new PropertyValue<bool>(nameof(ESSamlAuthModuleSettingsDto), nameof(RegisterNewUsers));
        
        [Required]
        [JsonPropertyName("registerNewUsers")]
        public bool RegisterNewUsers
        {
            get { return _registerNewUsers.GetValue(); }
            set { _registerNewUsers.SetValue(value); }
        }
    
        private PropertyValue<string?> _contactProfileId = new PropertyValue<string?>(nameof(ESSamlAuthModuleSettingsDto), nameof(ContactProfileId));
        
        [JsonPropertyName("contactProfileId")]
        public string? ContactProfileId
        {
            get { return _contactProfileId.GetValue(); }
            set { _contactProfileId.SetValue(value); }
        }
    
        private PropertyValue<ESSamlAttributeNamesDto> _attributeNames = new PropertyValue<ESSamlAttributeNamesDto>(nameof(ESSamlAuthModuleSettingsDto), nameof(AttributeNames));
        
        [Required]
        [JsonPropertyName("attributeNames")]
        public ESSamlAttributeNamesDto AttributeNames
        {
            get { return _attributeNames.GetValue(); }
            set { _attributeNames.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _idpUrl.SetAccessPath(path, validateHasBeenSet);
            _idpEntityId.SetAccessPath(path, validateHasBeenSet);
            _idpCertificateSHA256.SetAccessPath(path, validateHasBeenSet);
            _spEntityId.SetAccessPath(path, validateHasBeenSet);
            _sslKeystore.SetAccessPath(path, validateHasBeenSet);
            _registerNewUsers.SetAccessPath(path, validateHasBeenSet);
            _contactProfileId.SetAccessPath(path, validateHasBeenSet);
            _attributeNames.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
