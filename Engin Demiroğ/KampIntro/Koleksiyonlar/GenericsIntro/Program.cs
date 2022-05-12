using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           MyList<string> isimler = new MyList<string>();
            isimler.Add("Musa");
            Console.WriteLine(isimler.Length);
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

           
            foreach (string item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
