using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    class ClassFactory : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
            return new CodeWriterClass();
        }
    }
}
