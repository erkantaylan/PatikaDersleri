using System;
using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private readonly Type validatorType;

        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
                throw new Exception("Bu bir dogrulama sinifi degil");

            this.validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(validatorType);
            Type entityType = validatorType.BaseType.GetGenericArguments()[0];
            IEnumerable<object> entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities) ValidationTool.Validate(validator, entity);
        }
    }
}