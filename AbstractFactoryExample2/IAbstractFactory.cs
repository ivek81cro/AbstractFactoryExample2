using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample2
{
    public interface IAbstractFactory
    {
        IAbstractProduct CreateProduct();
    }
}
