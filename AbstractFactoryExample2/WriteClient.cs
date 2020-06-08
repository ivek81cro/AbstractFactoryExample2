using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    class WriteClient
    {
        IAbstractProduct classProduct;

        public WriteClient(IAbstractFactory factory)
        {
            classProduct = factory.CreateProduct();
        }

        public string GetCode()
        {
            if(classProduct.GetType()==typeof(CodeWriterStruct))
                return classProduct.Generate("Struct");
            return classProduct.Generate("Klasa");
        }
    }
}
