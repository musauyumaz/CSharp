using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper //Parolayı hashlemek için gerekli
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {//Verdiğimiz password değerinin hash ve salt karşılığını üretir
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;//Her kullanıcı için key oluşturur
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//Parantez içinde veriyi byte[] 'e çevirdik
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)//Login desteği sağlar 
        {//Logini kontrol olarak kullanırız
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
