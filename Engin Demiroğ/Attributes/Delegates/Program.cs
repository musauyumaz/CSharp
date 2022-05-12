using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelagate();
    public delegate void MyDelagate2(string text);
    public delegate int MyDelagate3(int number1,int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();


            MyDelagate myDelagate = customerManager.SendMessage;
            myDelagate += customerManager.ShowAlert;

            myDelagate -= customerManager.SendMessage;

            myDelagate();

            MyDelagate2 myDelagate2= customerManager.SendMessage2;
            myDelagate2+=customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            MyDelagate3 myDelagate3 = matematik.Topla;
            myDelagate3 += matematik.Carp;
            
            var sonuc = myDelagate3(2, 3);
            
           
            Console.WriteLine(sonuc);
            myDelagate2("Hello");

            Console.ReadLine();
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

}
