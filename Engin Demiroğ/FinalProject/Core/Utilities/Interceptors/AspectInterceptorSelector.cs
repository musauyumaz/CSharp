using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();//Class Attributelarını oku ve bir listeye koy
            var methodAttributes = type.GetMethod(method.Name)//Method Attributelarını oku ve bir listeye koy
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));//Default Loglama İçin Kullanılır

            return classAttributes.OrderBy(x => x.Priority).ToArray();//Onların çalışma sırasınıda öncelik sırasına göre sırala
        }
    }
}
