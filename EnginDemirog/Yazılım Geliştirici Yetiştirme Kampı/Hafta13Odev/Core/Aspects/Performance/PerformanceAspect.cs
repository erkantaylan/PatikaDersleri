using System.Diagnostics;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        private readonly int interval;
        private readonly Stopwatch stopwatch;

        public PerformanceAspect(int interval)
        {
            this.interval = interval;
            stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            if (stopwatch.Elapsed.TotalSeconds > interval)
                Debug.WriteLine(
                    $"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name} ---> {stopwatch.Elapsed.TotalSeconds}");
        }
    }
}