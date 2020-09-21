using System;
using System.Reflection;
using System.Text;

namespace Prototype.Models
{
    class Pen
    {
        public int Id { get; set; }
        public Color Color { get; set; }
        public Double Height { get; set; }
        public bool IsWorking { get; set; }

        public Pen(int id, Color color, double height, bool isWorking)
        {
            Id = id;
            Color = color;
            Height = height;
            IsWorking = isWorking;
        }
        public Pen Clone() { return (Pen)MemberwiseClone();}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                sb.AppendLine(propertyInfo.Name + ":" + propertyInfo.GetValue(this, null));
            }
            return sb.ToString();
        }
    }

    public enum Color
    {
        Blue,
        Black,
        Red
    }
}
