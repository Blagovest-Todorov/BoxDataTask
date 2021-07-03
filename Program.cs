using System;

namespace BoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            //the length, width and height.
            ////print the surface area, lateral surface area and the volume of the box
            ///
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                box.CalcSurfaceArea(length, width, height);
                box.CalcLateralSurfaceArea(length, width, height);
                box.CalcVolume(length, width, height);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }
    }
}
