using System;

namespace HouseWithRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Building[] b = new Building[5];

            b[0] = new House(5, "white", 3, "Ivan");
            House.Person person1 = new House.Person("Dragan");
            House.Room[] rooms = new House.Room[3];
            rooms[0] = new House.Bathroom(8.9, "blue");
            rooms[1] = new House.Bedroom(7.56, "green");
            rooms[2] = new House.Kitchen(16, "pink");

            b[0].BuildingInfo();
            Console.WriteLine(b[0].AreaCount(rooms[0].Area + rooms[1].Area + rooms[2].Area));
            person1.PersonInfo();

            rooms[0].RoomInfo();
            rooms[1].RoomInfo();
            rooms[2].RoomInfo();

            Console.WriteLine();


            b[1] = new House(5.5, "black", 4, "Petkan");
            House.Person person2 = new House.Person("Cvetan");
            House.Room[] rooms2 = new House.Room[4];
            rooms2[0] = new House.Bathroom(4.1, "purple");
            rooms2[1] = new House.Bedroom(7.1, "red");
            rooms2[2] = new House.Bedroom(10, "orange");
            rooms2[3] = new House.Kitchen(10.2, "white");

            b[1].BuildingInfo();
            Console.WriteLine(b[1].AreaCount(rooms2[0].Area + rooms2[1].Area + rooms2[2].Area + rooms2[3].Area));
            person2.PersonInfo();

            rooms2[0].RoomInfo();
            rooms2[1].RoomInfo();
            rooms2[2].RoomInfo();
            rooms2[3].RoomInfo();

        }
    }
}
