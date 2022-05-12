using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken //Erişim Token'ı(anahtarı)//Jeton mantığı Bu bir jeton
    {
        public string Token { get; set; }//Kullanıcı adı parola verecek bizde ona jeton vereceğiz
        public DateTime Expiration { get; set; } //Geçerlilik Süresi

    }
}
