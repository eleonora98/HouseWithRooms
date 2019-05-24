using System;

namespace HouseWithRooms
{
    class House : Building
    {

        public int Rooms { get; set; }
        public string Owner { get; set; }

        public House(double height, string color, int rooms, string owner)
            : base(height, color)
        {
            Rooms = rooms;
            Owner = owner;

        }
        public override void BuildingInfo()
        {
            Console.WriteLine("The house has {0} rooms. The owner is: {1}.", Rooms, Owner);
            base.BuildingInfo();
        }



        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }
            public void PersonInfo()
            {
                Console.WriteLine("{0} lives here.", Name);
            }

        }
        public class Room //nested base class Room
        {

            public double Area { get; set; }
            public string Color { get; set; }
            public Room(double area, string color)

            {
                Area = area;
                Color = color;
            }
            public virtual void RoomInfo()
            {
                Console.WriteLine("This room has an area of {0} and it is {1}", Area, Color);
            }

        }

        public class Bathroom : Room
        {

            public Bathroom(double area, string color)
                : base(area, color)
            {

            }
            public override void RoomInfo()
            {
                Console.WriteLine("Bathroom:");
                base.RoomInfo();
            }



        }
        public class Kitchen : Room
        {
            public Kitchen(double area, string color)
               : base(area, color)
            {
            }
            public override void RoomInfo()
            {
                Console.WriteLine("Kitchen:");
                base.RoomInfo();
            }


        }
        public class Bedroom : Room
        {
            public Bedroom(double area, string color)
               : base(area, color)
            {
            }
            public override void RoomInfo()
            {
                Console.WriteLine("Bedroom:");
                base.RoomInfo();

            }

        }
    }
}
