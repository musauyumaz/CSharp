using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine( dortIslem.Topla2());
            //Console.WriteLine( dortIslem.Topla(3,4));

            var type = typeof(DortIslem);

           //DortIslem dortIslem =(DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(4,5));
            //Console.WriteLine(dortIslem.Topla2());
            var instance = Activator.CreateInstance(type,6,5);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance,null));
            Console.WriteLine("--------------------------------------------------");

            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metotd Adı: {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    class MetodNameAttribute : Attribute
    {
        

        public MetodNameAttribute(string name)
        {
            
        }
    }
}
