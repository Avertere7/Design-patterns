using AbstractFactoryPattern.Base;


namespace AbstractFactoryPattern.FurnicureType.Modern
{
    class ModernFurnicureFactory : IFurnicureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
