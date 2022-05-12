using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
