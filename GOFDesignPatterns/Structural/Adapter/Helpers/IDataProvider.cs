using System.Collections.Generic;

namespace GOFDesignPatterns.Structural.Adapter
{
    //This is just to provide us with some in memory data
    public interface IDataProvider
    {
        IEnumerable<Employee> GetEmployees();
    }
}
