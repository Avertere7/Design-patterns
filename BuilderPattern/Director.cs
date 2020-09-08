using BuilderPattern.Base;


namespace BuilderPattern
{
    public class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ChangeBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Make(BuildOption option)
        {

            builder.BuildWalls();
            builder.AddRoof();
            builder.AddWindow();
            builder.AddDoor();

            if (option == BuildOption.LuxuryHouse)
            {
                builder.AddSwimmingPool();
                builder.AddGarden();
            }
        }
    }

    public enum BuildOption
    {
        BasicHouse,
        LuxuryHouse
    }
}
