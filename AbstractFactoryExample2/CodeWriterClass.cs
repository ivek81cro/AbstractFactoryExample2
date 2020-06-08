using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    class CodeWriterClass : IAbstractProduct
    {
        public string Generate(string name)
        {
            return $"class {name}\n{{\n\tpublic Class() {{ }}\n\n\tpublic void Method() {{ }}\n}}";
        }
    }
}
