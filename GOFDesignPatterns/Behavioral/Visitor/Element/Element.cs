namespace GOFDesignPatterns.Behavioral.Visitor
{
    //This is the Element abstract class
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
