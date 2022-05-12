using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute//Tüm Methodların Çatısı -->Tüm Methodlar bu kurallardan geçmek zorunda!!!
    {
        //invocation : Business Method
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation) //Parametre: çalıştırmak istediğimiz method -->Temel Try Catch Burada Yazıldı
        {
            var isSuccess = true;
            OnBefore(invocation);//Methodtan önce
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);//Hata Alındığında
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);//Başarılı Olduğunda
                }
            }
            OnAfter(invocation);//Method Sonunda
        }
    }
}
