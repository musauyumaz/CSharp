using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
namespace OOP3 { 
class FileLoggerService :ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Dosyaya loglandı");
    }
}
} 
