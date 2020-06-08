namespace AbstractFactoryExample2
{
    class CodeWriterStruct : IAbstractProduct
    {
        public string Generate(string name)
        {
            return $"struct {name}\n{{\n\tpublic void Method() {{ }}\n}}";
        }
    }
}