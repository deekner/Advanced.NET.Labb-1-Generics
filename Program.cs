using System;

namespace Labb_1_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added five Boxes
            BoxCollection box = new BoxCollection();
            box.Add(new Box(10, 10, 10));
            box.Add(new Box(9, 9, 9));
            box.Add(new Box(8, 8, 8));
            box.Add(new Box(7, 7, 7));
            box.Add(new Box(6, 6, 6));

            DisplayData(box);

            Console.WriteLine();
            Console.WriteLine("------- BOX ADDED WITH VALUE 10 ----------");
            //Added a box with same dimension
            box.Add(new Box(10, 10, 10));

            
            //Removed a box with the same values as an another box
            box.Remove(new Box(7, 7, 7));

            Console.WriteLine();
            Console.WriteLine("************************************************");

            DisplayData(box);
            Console.WriteLine();
            Console.WriteLine("Does the collection contain a box with these values?");
            Box BoxContain = new Box(10, 10, 10);
            Console.WriteLine("A box with dimensions {0}, {1}, {2}, [{3}]", BoxContain.height, BoxContain.length, BoxContain.width, box.Contains(BoxContain));


            Console.ReadKey();
        }
        public static void DisplayData(BoxCollection box)
        {
            Console.WriteLine("---------- Boxes ----------");
            Console.WriteLine("  Height  |  Length  | Width  ");
            foreach (Box b in box)
            {
                Console.WriteLine("  H: {0}  |  L: {1}  | W: {2} ", b.height, b.length, b.width);
            }
        }
    }
}
