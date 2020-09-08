using AbstractFactoryPattern.Base;

namespace AbstractFactoryPattern
{
    class Client
    {
        public IFurnicureFactory factory;

        public Client(IFurnicureFactory factory)
        {
            this.factory = factory;
        }

        public IChair GetChair()
        {
            return factory.CreateChair();
        }

        public ITable GetTable()
        {
            return factory.CreateTable();
        }
    }
}
