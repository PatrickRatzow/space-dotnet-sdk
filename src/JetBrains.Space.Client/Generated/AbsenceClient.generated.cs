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
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public partial class AbsenceClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public AbsenceClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create an absence for a given profile (member).
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AbsenceRecord> CreateAbsenceAsync(string member, string reason, string description, DateTime since, DateTime till, string icon, bool available = false, string? location = null, List<CustomFieldInputValue>? customFieldValues = null, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<AbsencesPostRequest, AbsenceRecord>("POST", $"api/http/absences{queryParameters.ToQueryString()}", 
                new AbsencesPostRequest
                { 
                    Member = member,
                    Reason = reason,
                    Description = description,
                    Location = location,
                    Since = since,
                    Till = till,
                    IsAvailable = available,
                    Icon = icon,
                    CustomFieldValues = customFieldValues,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Approve/unapprove an existing absence. Setting approve to true will approve the absence, false will remove the approval.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Approve absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task ApproveAbsenceAsync(string id, bool approve, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/absences/{id}/approve{queryParameters.ToQueryString()}", 
                new AbsencesForIdApprovePostRequest
                { 
                    IsApprove = approve,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<Batch<AbsenceRecord>> GetAllAbsencesAsync(AbsenceListMode viewMode = AbsenceListMode.All, string? skip = null, int? top = 100, string? member = null, List<string>? members = null, string? location = null, string? team = null, DateTime? since = null, DateTime? till = null, string? reason = null, Func<Partial<Batch<AbsenceRecord>>, Partial<Batch<AbsenceRecord>>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            if (skip != null) queryParameters.Append("$skip", skip);
            if (top != null) queryParameters.Append("$top", top?.ToString());
            if (member != null) queryParameters.Append("member", member);
            if (members != null) queryParameters.Append("members", members.Select(it => it));
            if (location != null) queryParameters.Append("location", location);
            if (team != null) queryParameters.Append("team", team);
            if (since != null) queryParameters.Append("since", since?.ToString("yyyy-MM-dd"));
            if (till != null) queryParameters.Append("till", till?.ToString("yyyy-MM-dd"));
            queryParameters.Append("viewMode", viewMode.ToEnumString());
            if (reason != null) queryParameters.Append("reason", reason);
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<AbsenceRecord>>()) : Partial<Batch<AbsenceRecord>>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<Batch<AbsenceRecord>>("GET", $"api/http/absences{queryParameters.ToQueryString()}", cancellationToken);
        }
        
        
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public IAsyncEnumerable<AbsenceRecord> GetAllAbsencesAsyncEnumerable(AbsenceListMode viewMode = AbsenceListMode.All, string? skip = null, int? top = 100, string? member = null, List<string>? members = null, string? location = null, string? team = null, DateTime? since = null, DateTime? till = null, string? reason = null, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
            => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllAbsencesAsync(viewMode: viewMode, top: top, member: member, members: members, location: location, team: team, since: since, till: till, reason: reason, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<AbsenceRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<AbsenceRecord>.Default())), skip, cancellationToken);
    
        /// <summary>
        /// Get absences for a given profile id.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<List<AbsenceRecord>> GetAllAbsencesByMemberAsync(string member, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<AbsenceRecord>>("GET", $"api/http/absences/member:{member}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <summary>
        /// Get an absence.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AbsenceRecord> GetAbsenceAsync(string id, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<AbsenceRecord>("GET", $"api/http/absences/{id}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <summary>
        /// Update an existing absence. Optional parameters will be ignored when not specified, and updated otherwise.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AbsenceRecord> UpdateAbsenceAsync(string id, bool available, string? member = null, string? reason = null, string? description = null, string? location = null, DateTime? since = null, DateTime? till = null, string? icon = null, List<CustomFieldInputValue>? customFieldValues = null, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceRecord>()) : Partial<AbsenceRecord>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<AbsencesForIdPatchRequest, AbsenceRecord>("PATCH", $"api/http/absences/{id}{queryParameters.ToQueryString()}", 
                new AbsencesForIdPatchRequest
                { 
                    Member = member,
                    Reason = reason,
                    Description = description,
                    Location = location,
                    Since = since,
                    Till = till,
                    IsAvailable = available,
                    Icon = icon,
                    CustomFieldValues = customFieldValues,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Archive/restore an existing absence. Setting delete to true will archive the absence, false will restore it.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit absences</term>
        /// </item>
        /// <item>
        /// <term>Create or edit past absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteAbsenceAsync(string id, bool delete = true, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("delete", delete.ToString("l"));
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <summary>
        /// Delete approval for a given absence.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Approve absences</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteAbsenceApprovalAsync(string id, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}/delete-approval{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public AbsenceReasonClient AbsenceReasons => new AbsenceReasonClient(_connection);
        
        public partial class AbsenceReasonClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public AbsenceReasonClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a new absence reason.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<AbsenceReasonRecord> CreateAbsenceReasonAsync(string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<AbsencesAbsenceReasonsPostRequest, AbsenceReasonRecord>("POST", $"api/http/absences/absence-reasons{queryParameters.ToQueryString()}", 
                    new AbsencesAbsenceReasonsPostRequest
                    { 
                        Name = name,
                        Description = description,
                        IsDefaultAvailability = defaultAvailability,
                        IsApprovalRequired = approvalRequired,
                        Icon = icon,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Get available absence reasons.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<AbsenceReasonRecord>> GetAllAbsenceReasonsAsync(bool withArchived = false, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("withArchived", withArchived.ToString("l"));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<AbsenceReasonRecord>>("GET", $"api/http/absences/absence-reasons{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Get an absence reason.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<AbsenceReasonRecord> GetAbsenceReasonAsync(string id, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<AbsenceReasonRecord>("GET", $"api/http/absences/absence-reasons/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Update an existing absence reason.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<AbsenceReasonRecord> UpdateAbsenceReasonAsync(string id, string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceReasonRecord>()) : Partial<AbsenceReasonRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<AbsencesAbsenceReasonsForIdPatchRequest, AbsenceReasonRecord>("PATCH", $"api/http/absences/absence-reasons/{id}{queryParameters.ToQueryString()}", 
                    new AbsencesAbsenceReasonsForIdPatchRequest
                    { 
                        Name = name,
                        Description = description,
                        IsDefaultAvailability = defaultAvailability,
                        IsApprovalRequired = approvalRequired,
                        Icon = icon,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Archive/restore an existing absence reason. Setting delete to true will archive the absence reason, false will restore it.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit absence types</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task DeleteAbsenceReasonAsync(string id, bool delete = true, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("delete", delete.ToString("l"));
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/absences/absence-reasons/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
    }
    
}
