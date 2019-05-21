using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GOFDesignPatterns.Structural.Adapter.Target
{
    //This is the Expected Interface that the client code is expecting
    // its expecting to pass a collection of employee objects and have it return a Json Formatted data to the user
    public class JsonConverter : IJsonConverter
    {
        private readonly IEnumerable<Employee> _employees;

        public JsonConverter(IEnumerable<Employee> employees)
        {
            _employees = employees;
        }

        public void ConvertToJson()
        {
            //serialising the employees object collection into a json string
            var employeesInJsonFormat = JsonConvert.SerializeObject(_employees, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(employeesInJsonFormat);
        }
    }
}
