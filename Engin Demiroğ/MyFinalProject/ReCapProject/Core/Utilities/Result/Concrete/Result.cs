using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class Result : IResult
    
    {
        public Result(bool success,string message):this(success)
        // this içinde kullanıldığı class'ı ifade eder. ":this(success)" yazımı
        // Result class'ının tek değişkenli constructoruna success değerini gönderir ve onun çalışmasını sağlar
        {
            Message = message;// get gibi ReadOnly olan elemanlar sadece constructor içerisinde set edilebilmektedir.
        }
        public Result(bool success)// overload yaparak "message" kullanılmadan da eylemin gerçekleştirilmesine izin veriliyor.
        {
            Success = success;// get gibi ReadOnly olan elemanlar sadece constructor içerisinde set edilebilmektedir.
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
