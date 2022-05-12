using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(2,3));

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2=()=>new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();
        }
        
        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
