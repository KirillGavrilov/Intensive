using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intensive
{
    class Program
    {
        static void Main(string[] args)
        {
            bool part2 = false;


         
                if (part2)
                {
                    var origin = new TestForMemberwiseClone(5, "Test origin");
                    var clone = origin.GetClone();

                    Console.WriteLine("Origin object");
                    Console.WriteLine("Count = {0}", origin.Count);
                    Console.WriteLine("Name = {0}", origin.Name);
                    Console.WriteLine("AbstractClass.Count = {0}", origin.AbstractClass.Count);
                    Console.WriteLine("AbstractClass.Name = {0}", origin.AbstractClass.Name);
                    Console.WriteLine("AbstractStructure.Count = {0}", origin.AbstractStructure.Count);
                    Console.WriteLine("AbstractStructure.Name = {0}", origin.AbstractStructure.Name);

                    Console.WriteLine();

                    Console.WriteLine("Clone object");
                    Console.WriteLine("Count = {0}", clone.Count);
                    Console.WriteLine("Name = {0}", clone.Name);
                    Console.WriteLine("AbstractClass.Count = {0}", clone.AbstractClass.Count);
                    Console.WriteLine("AbstractClass.Name = {0}", clone.AbstractClass.Name);
                    Console.WriteLine("AbstractStructure.Count = {0}", clone.AbstractStructure.Count);
                    Console.WriteLine("AbstractStructure.Name = {0}", clone.AbstractStructure.Name);

                    origin.Update();
                    Console.WriteLine();

                    Console.WriteLine("Origin object");
                    Console.WriteLine("Count = {0}", origin.Count);
                    Console.WriteLine("Name = {0}", origin.Name);
                    Console.WriteLine("AbstractClass.Count = {0}", origin.AbstractClass.Count);
                    Console.WriteLine("AbstractClass.Name = {0}", origin.AbstractClass.Name);
                    Console.WriteLine("AbstractStructure.Count = {0}", origin.AbstractStructure.Count);
                    Console.WriteLine("AbstractStructure.Name = {0}", origin.AbstractStructure.Name);

                    Console.WriteLine();

                    Console.WriteLine("Clone object");
                    Console.WriteLine("Count = {0}", clone.Count);
                    Console.WriteLine("Name = {0}", clone.Name);
                    Console.WriteLine("AbstractClass.Count = {0}", clone.AbstractClass.Count);
                    Console.WriteLine("AbstractClass.Name = {0}", clone.AbstractClass.Name);
                    Console.WriteLine("AbstractStructure.Count = {0}", clone.AbstractStructure.Count);
                    Console.WriteLine("AbstractStructure.Name = {0}", clone.AbstractStructure.Name);

                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(Days.Tuesday | Days.Thursday);


                    
                    Console.WriteLine(Enum.GetName(typeof(Days), 1));

                    Console.ReadLine();
                }

        }
    }
}
