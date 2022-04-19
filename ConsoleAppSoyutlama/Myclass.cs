using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSoyutlama
{
    abstract class Myclass
    {
        abstract class AbstractClass
        {
            public void deneme()
            {
                Console.WriteLine("Deneme");
            }
        }
        class Abstract
        {
            class DerivedClass1 : AbstractClass
            {

            }
            class DerivedClass2 : AbstractClass
            {

            }
            
        }
    }
}
