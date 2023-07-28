using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Connect();
            smartPhone.Recharge(20);
            Console.WriteLine(smartPhone.Display());
            Laptop laptop=new Laptop();
            laptop.Recharge(20);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();


        }
    }
}
