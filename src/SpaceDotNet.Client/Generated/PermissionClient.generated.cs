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
    public partial class PermissionClient
    {
        private readonly Connection _connection;
        
        public PermissionClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<bool> CheckPermissionAsync(PrincipalIn principal, string uniqueRightCode, PermissionTarget target)
            => await _connection.RequestResourceAsync<PermissionsCheckPermissionPostRequest, bool>("POST", $"api/http/permissions/check-permission", 
                new PermissionsCheckPermissionPostRequest { 
                    Principal = principal,
                    UniqueRightCode = uniqueRightCode,
                    Target = target,
                }
        );
    
        public async Task<RightsWithHierarchy> GetAllPermissionsAsync(Func<Partial<RightsWithHierarchy>, Partial<RightsWithHierarchy>>? partial = null)
            => await _connection.RequestResourceAsync<RightsWithHierarchy>("GET", $"api/http/permissions?$fields={(partial != null ? partial(new Partial<RightsWithHierarchy>()) : Partial<RightsWithHierarchy>.Default())}");
    
        public SnapshotClient Snapshots => new SnapshotClient(_connection);
        
        public partial class SnapshotClient
        {
            private readonly Connection _connection;
            
            public SnapshotClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PermissionSnapshot> CreateSnapshotAsync(Func<Partial<PermissionSnapshot>, Partial<PermissionSnapshot>>? partial = null)
                => await _connection.RequestResourceAsync<PermissionSnapshot>("POST", $"api/http/permissions/snapshots?$fields={(partial != null ? partial(new Partial<PermissionSnapshot>()) : Partial<PermissionSnapshot>.Default())}");
        
            public async Task<List<PermissionSnapshot>> GetAllSnapshotsAsync(Func<Partial<PermissionSnapshot>, Partial<PermissionSnapshot>>? partial = null)
                => await _connection.RequestResourceAsync<List<PermissionSnapshot>>("GET", $"api/http/permissions/snapshots?$fields={(partial != null ? partial(new Partial<PermissionSnapshot>()) : Partial<PermissionSnapshot>.Default())}");
        
            public async Task<PermissionSnapshotContent> GetSnapshotAsync(string id, string? principal = null, string? right = null, Func<Partial<PermissionSnapshotContent>, Partial<PermissionSnapshotContent>>? partial = null)
                => await _connection.RequestResourceAsync<PermissionSnapshotContent>("GET", $"api/http/permissions/snapshots/{id}?principal={principal?.ToString() ?? "null"}&right={right?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<PermissionSnapshotContent>()) : Partial<PermissionSnapshotContent>.Default())}");
        
            public async Task DeleteSnapshotAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/permissions/snapshots/{id}");
        
            public ComparisonClient Comparison => new ComparisonClient(_connection);
            
            public partial class ComparisonClient
            {
                private readonly Connection _connection;
                
                public ComparisonClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<PermissionComparisonContent> GetComparisonAsync(string id1, string id2, Func<Partial<PermissionComparisonContent>, Partial<PermissionComparisonContent>>? partial = null)
                    => await _connection.RequestResourceAsync<PermissionComparisonContent>("GET", $"api/http/permissions/snapshots/comparison?id1={id1.ToString()}&id2={id2.ToString()}&$fields={(partial != null ? partial(new Partial<PermissionComparisonContent>()) : Partial<PermissionComparisonContent>.Default())}");
            
            }
        
            public PrincipalClient Principals => new PrincipalClient(_connection);
            
            public partial class PrincipalClient
            {
                private readonly Connection _connection;
                
                public PrincipalClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<List<PermissionSnapshotPrincipal>> GetPrincipalAsync(string id, Func<Partial<PermissionSnapshotPrincipal>, Partial<PermissionSnapshotPrincipal>>? partial = null)
                    => await _connection.RequestResourceAsync<List<PermissionSnapshotPrincipal>>("GET", $"api/http/permissions/snapshots/{id}/principals?$fields={(partial != null ? partial(new Partial<PermissionSnapshotPrincipal>()) : Partial<PermissionSnapshotPrincipal>.Default())}");
            
            }
        
            public RightClient Rights => new RightClient(_connection);
            
            public partial class RightClient
            {
                private readonly Connection _connection;
                
                public RightClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<List<PermissionSnapshotRight>> GetRightAsync(string id, Func<Partial<PermissionSnapshotRight>, Partial<PermissionSnapshotRight>>? partial = null)
                    => await _connection.RequestResourceAsync<List<PermissionSnapshotRight>>("GET", $"api/http/permissions/snapshots/{id}/rights?$fields={(partial != null ? partial(new Partial<PermissionSnapshotRight>()) : Partial<PermissionSnapshotRight>.Default())}");
            
            }
        
        }
    
    }
    
}
