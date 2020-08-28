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
    public sealed class ESProfileLogin
         : IPropagatePropertyAccessPath
    {
        public ESProfileLogin() { }
        
        public ESProfileLogin(string identifier, ESAuthModule authModule, ESProfileLoginDetails details, AccessRecord? access = null)
        {
            Identifier = identifier;
            AuthModule = authModule;
            Details = details;
            Access = access;
        }
        
        private PropertyValue<string> _identifier = new PropertyValue<string>(nameof(ESProfileLogin), nameof(Identifier));
        
        [Required]
        [JsonPropertyName("identifier")]
        public string Identifier
        {
            get { return _identifier.GetValue(); }
            set { _identifier.SetValue(value); }
        }
    
        private PropertyValue<ESAuthModule> _authModule = new PropertyValue<ESAuthModule>(nameof(ESProfileLogin), nameof(AuthModule));
        
        [Required]
        [JsonPropertyName("authModule")]
        public ESAuthModule AuthModule
        {
            get { return _authModule.GetValue(); }
            set { _authModule.SetValue(value); }
        }
    
        private PropertyValue<ESProfileLoginDetails> _details = new PropertyValue<ESProfileLoginDetails>(nameof(ESProfileLogin), nameof(Details));
        
        [Required]
        [JsonPropertyName("details")]
        public ESProfileLoginDetails Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        private PropertyValue<AccessRecord?> _access = new PropertyValue<AccessRecord?>(nameof(ESProfileLogin), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessRecord? Access
        {
            get { return _access.GetValue(); }
            set { _access.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _identifier.SetAccessPath(path, validateHasBeenSet);
            _authModule.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
            _access.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
