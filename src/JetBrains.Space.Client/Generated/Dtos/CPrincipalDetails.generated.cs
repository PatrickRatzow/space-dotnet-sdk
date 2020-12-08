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
    public interface CPrincipalDetails
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static CAutomationTaskPrincipalDetails CAutomationTaskPrincipalDetails(PRProject project, string name, string id)
            => new CAutomationTaskPrincipalDetails(project: project, name: name, id: id);
        
        public static CBuiltInServicePrincipalDetails CBuiltInServicePrincipalDetails(string name)
            => new CBuiltInServicePrincipalDetails(name: name);
        
        public static CExternalServicePrincipalDetails CExternalServicePrincipalDetails(ESService service)
            => new CExternalServicePrincipalDetails(service: service);
        
        public static CUserPrincipalDetails CUserPrincipalDetails(TDMemberProfile user)
            => new CUserPrincipalDetails(user: user);
        
        public static CUserWithEmailPrincipalDetails CUserWithEmailPrincipalDetails(string name, string email)
            => new CUserWithEmailPrincipalDetails(name: name, email: email);
        
    }
    
}
