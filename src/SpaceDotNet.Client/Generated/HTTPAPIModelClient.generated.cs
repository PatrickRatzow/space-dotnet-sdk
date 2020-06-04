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
    public partial class HTTPAPIModelClient
    {
        private readonly Connection _connection;
        
        public HTTPAPIModelClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<HAModelDto> GetHTTPAPIModelAsync(Func<Partial<HAModelDto>, Partial<HAModelDto>> partial = null)
            => await _connection.RequestResourceAsync<HAModelDto>("GET", $"api/http/http-api-model?$fields={(partial != null ? partial(new Partial<HAModelDto>()) : Partial<HAModelDto>.Default())}");
    
    }
    
}
