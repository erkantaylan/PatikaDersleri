using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Caching
{
    public class CacheAspect : MethodInterception
    {
        private readonly ICacheManager cacheManager;
        private readonly int duration;

        public CacheAspect(int duration = 60)
        {
            this.duration = duration;
            cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            List<object> arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            if (cacheManager.IsAdd(key))
            {
                invocation.ReturnValue = cacheManager.Get(key);
                return;
            }

            invocation.Proceed();
            cacheManager.Add(key, invocation.ReturnValue, duration);
        }
    }
}