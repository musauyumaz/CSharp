using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper//SecurityKey ve algoritmasını belirlediğimiz yer
    {//Sisteminde doğrulama yapması gerektiği için kullandık
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)//Anahtarımız
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
