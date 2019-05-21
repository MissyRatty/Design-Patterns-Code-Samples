using System;
using System.Linq;
using System.Xml.Linq;

namespace GOFDesignPatterns.Structural.Adapter
{
    //This is the existing class (Adaptee)
    public class XmlConverter : IXmlConverter
    {
        private readonly IDataProvider _dataProvider;

        public XmlConverter(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        //Create an xml representation of my employee data
        public XDocument GetXml()
        {
            var document = new XDocument();
            var element = new XElement("Employees");
            var attributes = _dataProvider.GetEmployees()
                .Select(x => new XElement("Employee",
                new XAttribute("FirstName", x.FirstName),
                new XAttribute("LastName", x.LastName),
                new XAttribute("City", x.City)));

            element.Add(attributes);
            document.Add(element);

            Console.WriteLine(document);

            return document;
        }
    }
}
