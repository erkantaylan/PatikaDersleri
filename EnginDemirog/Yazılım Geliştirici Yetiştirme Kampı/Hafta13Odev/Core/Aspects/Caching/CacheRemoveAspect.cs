using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private readonly ICacheManager cacheManager;
        private readonly string pattern;

        public CacheRemoveAspect(string pattern)
        {
            this.pattern = pattern;
            cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            cacheManager.RemoveByPattern(pattern);
        }
    }
}