// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class OIDCDiscovery
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "OIDCDiscovery";
        
        public static OIDCDiscoveryError Error(string code, string description)
            => new OIDCDiscoveryError(code: code, description: description);
        
        public static OIDCDiscoverySuccess Success(string issuer, string authorizationEndpoint, string deviceAuthorizationEndpoint, string tokenEndpoint, string userinfoEndpoint, string revocationEndpoint, string jwksUri)
            => new OIDCDiscoverySuccess(issuer: issuer, authorizationEndpoint: authorizationEndpoint, deviceAuthorizationEndpoint: deviceAuthorizationEndpoint, tokenEndpoint: tokenEndpoint, userinfoEndpoint: userinfoEndpoint, revocationEndpoint: revocationEndpoint, jwksUri: jwksUri);
        
        public OIDCDiscovery() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
