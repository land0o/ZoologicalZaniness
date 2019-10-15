using System;

namespace ZoologicalZaniness
{
    public class Zoo
    {
        public string Name { get; set; }
        public string TypeOfAni { get; set; }

        public Zoo(string name, string type)
        {
            Name = name;
            TypeOfAni = type;
        }

        public class Dog : IWalking
        {
            public void Run()
            {
                Console.WriteLine("Animal is running");
            }
            public void Walk()
            {
                Console.WriteLine("Animal is currently walking");
            }
        }
        public class SeaTurtle : IWalking, ISwimming
        {
            public int MaximumDepth { get; } = 100;
            public void Run()
            {
                Console.WriteLine("Animal is running");
            }
            public void Walk()
            {
                Console.WriteLine("Animal is currently walking");
            }

            public void Swim()
            {
                Console.WriteLine("Animal is now swimming");
            }
        }
        public class Salmon : ISwimming
        {
            public int MaximumDepth { get; } = 100;
            public void Swim()
            {
                Console.WriteLine("Animal is now swimming");
            }
        }
    }
}