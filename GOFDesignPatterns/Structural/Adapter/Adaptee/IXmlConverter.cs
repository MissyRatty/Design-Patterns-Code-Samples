using System.Xml.Linq;

namespace GOFDesignPatterns.Structural.Adapter
{
    public interface IXmlConverter
    {
        XDocument GetXml();
    }
}
