using System;

namespace excercise
{
    class Smartphone
    {
        public BrandList Brand;
        public ProcessorType Processor;
        public DisplayType Display;
        public DiskSize Disk;
        public RamSize Ram;
        public CameraMP Camera;
    }

    
    class Program
    {
        static void Main(string[] args)
        {
           MakeASmartphone();
        }

        static void MakeASmartphone(){

            Smartphone Model = new Smartphone();
            Console.WriteLine("Select a Brand");
            for (int i = 0; i < Enum.GetNames(typeof(BrandList)).Length; i++)
            {
                Console.WriteLine($"{i}. {Enum.GetNames(typeof(BrandList))[i]}");
            }
            Console.ReadKey();
            // Console.WriteLine($"{}");
        }
    }
}