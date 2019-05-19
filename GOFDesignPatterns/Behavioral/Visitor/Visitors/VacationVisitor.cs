using System;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    //Concrete Visitor class which will define the context for the visit algorithm inherited from the IVisitor
    // This visitor class calculates employee vacation days
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = (Staff)element;

            //calculate employee vacation days
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name,
                employee.Name, employee.VacationDays);
        }
    }
}
