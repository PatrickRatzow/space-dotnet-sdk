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
    public partial class AdministrationClient
    {
        private readonly Connection _connection;
        
        public AdministrationClient(Connection connection)
        {
            _connection = connection;
        }
        
        public SupportClient Support => new SupportClient(_connection);
        
        public partial class SupportClient
        {
            private readonly Connection _connection;
            
            public SupportClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<SupportProfileDTODto> CreateSupportAsync(Func<Partial<SupportProfileDTODto>, Partial<SupportProfileDTODto>> partial = null)
                => await _connection.RequestResourceAsync<SupportProfileDTODto>("POST", $"api/http/administration/support?$fields={(partial != null ? partial(new Partial<SupportProfileDTODto>()) : Partial<SupportProfileDTODto>.Default())}");
        
        }
    
    }
    
}
