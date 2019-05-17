using GOFDesignPatterns.Structural.Adapter.Target;

namespace GOFDesignPatterns.Structural.Adapter
{
    //This is the Adapter Class
    public class XmlToJsonAdapter : IXmlToJson
    {
        //this is a reference to the existing (Adaptee) class, XmlConverter
        private readonly IXmlConverter _xmlConverter;
        private readonly IJsonConverter _jsonConverter;

        public XmlToJsonAdapter(IXmlConverter xmlConverter, IJsonConverter jsonConverter)
        {
            _xmlConverter = xmlConverter;
            _jsonConverter = jsonConverter;
        }


        public void ConvertXmlToJson()
        {
            _jsonConverter.ConvertToJson();
        }
    }
}
