// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T15:15:45.1565261+00:00
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
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class ReviewRevisionsChangedType : Enumeration
    {
        private ReviewRevisionsChangedType(string value) : base(value) { }
        
        public static readonly ReviewRevisionsChangedType Created = new ReviewRevisionsChangedType("Created");
        public static readonly ReviewRevisionsChangedType Added = new ReviewRevisionsChangedType("Added");
        public static readonly ReviewRevisionsChangedType Removed = new ReviewRevisionsChangedType("Removed");
    }
    
}
