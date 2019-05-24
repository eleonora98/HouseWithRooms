using System;

namespace HouseWithRooms
{
    class Building
    {
        public double Area { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public Building(double height, string color)
        {
            Height = height;
            Color = color;
        }
        public virtual void BuildingInfo()
        {

            Console.WriteLine("Its height is: {0}. Its color is {1}."
                , Height, Color);
            Console.Write("Its area is: ");
        }
        public double AreaCount(double sum)
        {
            return sum += Area;
        }



    }
}

