using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    public interface IAbstractProduct
    {
        string Generate(string name);
    }
}
