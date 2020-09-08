using AbstractFactoryPattern.FurnicureType.Modern;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new NormalFurnicureFactory());
            client.GetTable().SetTheTable();
            client.GetChair().SitOn();

            Client modernClient = new Client(new ModernFurnicureFactory());
            modernClient.GetTable().SetTheTable();
            modernClient.GetChair().SitOn();
        }
    }
}
