using System;
using System.Collections.Generic;
using Business.Constans;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac
{
    namespace Business.BusinessAspects.Autofac
    {
        public class SecuredOperation : MethodInterception
        {
            private readonly IHttpContextAccessor httpContextAccessor;
            private readonly string[] roles;

            public SecuredOperation(string roles)
            {
                this.roles = roles.Split(',');
                httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
            }

            protected override void OnBefore(IInvocation invocation)
            {
                List<string> roleClaims = httpContextAccessor.HttpContext.User.ClaimRoles();
                foreach (var role in roles)
                    if (roleClaims.Contains(role))
                        return;
                throw new Exception(Messages.AuthorizationDenied);
            }
        }
    }
}