using AbstractFactoryPattern.Base;


namespace AbstractFactoryPattern.FurnicureType.Modern
{
    class NormalFurnicureFactory : IFurnicureFactory
    {
        public IChair CreateChair()
        {
            return new NormalChair();
        }


        public ITable CreateTable()
        {
            return new NormalTable();
        }
    }
}
