using System.Collections.Generic;

namespace GOFDesignPatterns.Structural.Adapter
{
    //This is just to provide us with some in memory data
    public class DataProvider : IDataProvider
    {
        public IEnumerable<Employee> GetEmployees() => new List<Employee>
        {
            new Employee { FirstName = "Rahmat", LastName = "Boakye", City = "Eastwood"},
            new Employee { FirstName = "John", LastName = "Gerrard", City = "Beeston"},
            new Employee { FirstName = "Mary", LastName = "Walker", City = "Derby"}
        };
    }
}
