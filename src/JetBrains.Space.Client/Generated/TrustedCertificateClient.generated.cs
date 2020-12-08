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
    public partial class TrustedCertificateClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public TrustedCertificateClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<TrustedCertificate> CreateTrustedCertificateAsync(string alias, string data, bool archived, Func<Partial<TrustedCertificate>, Partial<TrustedCertificate>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<TrustedCertificate>()) : Partial<TrustedCertificate>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<TrustedCertificatesPostRequest, TrustedCertificate>("POST", $"api/http/trusted-certificates{queryParameters.ToQueryString()}", 
                new TrustedCertificatesPostRequest
                { 
                    Alias = alias,
                    Data = data,
                    IsArchived = archived,
                }, cancellationToken);
        }
        
    
        public async Task<List<TrustedCertificate>> GetAllTrustedCertificatesAsync(Func<Partial<TrustedCertificate>, Partial<TrustedCertificate>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<TrustedCertificate>()) : Partial<TrustedCertificate>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<TrustedCertificate>>("GET", $"api/http/trusted-certificates{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public async Task<CertificateInfo> InfoAsync(string data, Func<Partial<CertificateInfo>, Partial<CertificateInfo>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("data", data);
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<CertificateInfo>()) : Partial<CertificateInfo>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<CertificateInfo>("GET", $"api/http/trusted-certificates/info{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public async Task UpdateTrustedCertificateAsync(string id, string? alias = null, string? data = null, bool? archived = false, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("PATCH", $"api/http/trusted-certificates/{id}{queryParameters.ToQueryString()}", 
                new TrustedCertificatesForIdPatchRequest
                { 
                    Alias = alias,
                    Data = data,
                    IsArchived = archived,
                }, cancellationToken);
        }
        
    
        public async Task DeleteTrustedCertificateAsync(string id, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/trusted-certificates/{id}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
    }
    
}
