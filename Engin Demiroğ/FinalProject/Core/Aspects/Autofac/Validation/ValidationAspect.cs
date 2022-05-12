using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Bu bir interceptordır o yüzden inherit ettik -->Bu Bir Attribute //Aspect
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)//Parametre--> Bana Validator Type ver Attributelara Tipleri Böyle Atarız Type ile
        {
            //Defensive coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))//Eğer Yazılımcı IValidator'ı İmplemente eden bir class yollamazsa onu uyar
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//Reflection:Çalışma Anında Newleme Yapılıyor -->Validator için instance oluştur
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//Validator'ın Çalışma Tipini Bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//ilgili methodun parametrelerini bul -->validatorun tipine eşit olan parametleri bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);//ValidationTool Kullanarak Validate Et
            }
        }
        
    }
}
