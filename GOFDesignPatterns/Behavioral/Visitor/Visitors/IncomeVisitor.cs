using System;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    //Concrete Visitor class which will define the context for the visit algorithm inherited from the IVisitor
    // This visitor class calculates employee income
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = (Staff)element;

            //give employee pay raise
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name,
                employee.Name, employee.Income);
        }
    }
}
