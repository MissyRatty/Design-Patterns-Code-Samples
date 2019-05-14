namespace GOFDesignPatterns.Creational.Prototype
{
    public class CloneFactory
    {
        public IAnimalPrototype GetClone(IAnimalPrototype animalSample)
        {
            return animalSample.MakeCopy();
        }
    }
}
