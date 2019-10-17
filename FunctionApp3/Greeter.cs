namespace FunctionApp3
{
    public interface IGreeter
    {
        string GreetMessage(string name);
    }

    public class Greeting : IGreeter
    {
        public string GreetMessage(string name)
        {
            return $"Hello {name}..";
        }
    }
}