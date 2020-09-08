

namespace AbstractFactoryPattern.Base
{
    public interface IFurnicureFactory
    {
        public IChair CreateChair();
        public ITable CreateTable();

    }
}
