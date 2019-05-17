namespace GOFDesignPatterns.Structural.Adapter.Target
{
    //This the expected interface that the client code wants to use
    //e.g: the client code wants to display some json formatted data to users
    public interface IJsonConverter
    {
        void ConvertToJson();
    }
}
