namespace GOFDesignPatterns.Behavioral.Visitor
{
    //Visitor interface, this defines the operation to be performed on each concrete element in the object structure.
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
