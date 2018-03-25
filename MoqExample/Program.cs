namespace MoqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteRepository = new Repository();
            var example = new BandController(concreteRepository);
        }
    }
}
