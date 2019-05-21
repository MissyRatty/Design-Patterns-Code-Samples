using System.Xml.Linq;

namespace GOFDesignPatterns.Structural.Adapter
{
    //This is the existing interface that we want to convert to an interface that the client code is expecting
    public interface IXmlConverter
    {
        XDocument GetXml();
    }
}
