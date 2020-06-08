namespace AbstractFactoryExample2
{
    class StructFactory : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
            return new CodeWriterStruct();
        }
    }
}