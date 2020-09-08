using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Base
{
    public interface IBuilder
    {
        public void Reset();
        public void BuildWalls();
        public void AddWindow();
        public void AddSwimmingPool();
        public void AddRoof();
        public void AddDoor();
        public void AddGarden();

    }
}
