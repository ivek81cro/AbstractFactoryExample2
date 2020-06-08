using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    class CodeWriterAClass : IAbstractProduct
    {
        public string Generate(string name)
        {
            return $"abstract class {name}\n{{\n\tpublic abstract void Method();\n}}";
        }
    }
}