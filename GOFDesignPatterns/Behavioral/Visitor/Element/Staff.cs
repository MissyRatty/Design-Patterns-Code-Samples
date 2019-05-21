namespace GOFDesignPatterns.Behavioral.Visitor
{
    //This a concrete element class
    public class Staff : Element
    {
        public Staff(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        // Gets or sets the name
        public string Name { get; set; }

        // Gets or sets income
        public double Income { get; set; }

        // Gets or sets number of vacation days
        public int VacationDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
