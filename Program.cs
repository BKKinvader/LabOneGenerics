namespace Advance.NET_labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BoxCollection
            BoxCollection boxes = new BoxCollection();

            //Add Box
            Box box1 = new Box(1, 1, 1);
            Box box2 = new Box(2, 2, 2);
            Box box3 = new Box(3, 3, 3);
            Box box4 = new Box(4, 4, 4);
            Box box5 = new Box(5, 5, 5);
            Box box6 = new Box(6, 6, 6);
            Box box7 = new Box(6, 6, 6);



            //Add Box to BoxCollection
            boxes.Add(box1);
            boxes.Add(box2);
            boxes.Add(box3);
            boxes.Add(box4);
            boxes.Add(box5);
            boxes.Add(box6);
            

            Console.WriteLine("--------------Display all Boxes----------------");
            DisplayData(boxes);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n----> Adding Box Test H=6 W=6 L=6");
            boxes.Add(box7);
            Console.WriteLine("\n-----------------------ERROR--------------------");

            //Remove Box
            Console.WriteLine("\n----> REMOVE Box 3 and 4");
            boxes.Remove(box3);
            boxes.Remove(box4);
            Console.WriteLine("--------------Display all Boxes----------------");
            DisplayData(boxes);
            Console.WriteLine("-----------------------------------------------");


            //Checking Existing Box
            Console.WriteLine("-------------Checking Box 5x5x5 --------------");
            var boxDim5 = boxes.Where(box => box.Height == 5 && box.Length == 6 && box.Width == 5);
            if (boxDim5.Any())
            {
                foreach (var box in boxDim5)
                {
                    Console.WriteLine($"Box with dimensions {box.Height}x{box.Length}x{box.Width} found.");
                }
            }
            else
            {
                Console.WriteLine("No boxes with dimensions 5x5x5 found.");
            }



            Console.ReadKey();
        }


        public static void DisplayData(BoxCollection boxList)
        {
            Console.WriteLine("\nHeight\tLenght\tWidth\tHash Code");
            foreach (Box b in boxList)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                b.Height.ToString(), b.Length.ToString(), b.Width.ToString(), b.GetHashCode().ToString());
            }
        }
        
    }
}