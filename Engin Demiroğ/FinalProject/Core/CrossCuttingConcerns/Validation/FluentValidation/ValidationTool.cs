using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)//Doğrulama sınıfının implemente olduğu interface ve doğrulanacak örnek
        {
            var context = new ValidationContext<object>(entity);//--> Doğrulama contexti oluştur parametre için 
            //ProductValidator productValidator = new ProductValidator -->kuralları yazdığımız sınıfı kullanmak için newledik.
            var result = validator.Validate(context);//Biz bağımlılığı sevmediğimizden sınıfın implement edildiği interface'i parametre olarak istedik...
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
