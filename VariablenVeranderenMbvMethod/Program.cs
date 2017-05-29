using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablenVeranderenMbvMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyStruct ms = new MyStruct();
            ms.Beschrijving = "Hallo";
            Console.WriteLine(ms.Beschrijving);
            DoSomethingStructy(ms);
            Console.WriteLine(ms.Beschrijving); 
           
            Console.WriteLine(ms.Beschrijving);
            DoSomethingStructy(ref ms);
            Console.WriteLine(ms.Beschrijving);
        }
        static void DoSomethingClassy(MyClass c)
        {
            c.Beschrijving = "HACKED!";
        }
        static void DoSomethingStructy(MyStruct s)
        {
            s.Beschrijving = "HACKED?!";
        }
        static void DoSomethingStructy(ref MyStruct s)
        {
            s.Beschrijving = "HACKED!!";
        }
    }
    struct MyStruct
    {
        public string Beschrijving;
        public int Hoeveelheid;
    }
}
