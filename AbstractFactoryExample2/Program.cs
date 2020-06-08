using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory classObj = new ClassFactory();
            WriteClient wc = new WriteClient(classObj);
            Console.WriteLine(wc.GetCode() + '\n');

            IAbstractFactory classObj2 = new AbstractClassFactory();
            WriteClient wc2 = new WriteClient(classObj2);
            Console.WriteLine(wc2.GetCode() + '\n');

            IAbstractFactory classObj3 = new StructFactory();
            WriteClient wc3 = new WriteClient(classObj3);
            Console.WriteLine(wc3.GetCode() + '\n');

            Console.ReadKey();
        }
    }
}
