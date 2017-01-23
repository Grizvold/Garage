using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
namespace Ex03.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            int[] benny = { 1, 2, 3 };
            int[] arr = benny;
            arr[0] = 5;
            Console.WriteLine(arr[0]);
            Console.WriteLine(benny[0]);
            string a = "bbcdr", b= "bbcdr";
            int aa= a.GetHashCode(), bb=b.GetHashCode();
            float bf = 70;

            float chargingHours = ((int)bf / 60) + bf % 60;
            if (aa == bb)
            {
                Console.WriteLine("{0} - {1} -  FLOAT - {2}", aa, bb, chargingHours);
            }
            Wheel wh = new Wheel("Benny Sela Inc.", 15, 23);
            Wheel wh2 = new Wheel("Benny Rapper Inc.", 5, 22);
            Wheel[] whells = { wh, wh, wh2, wh2 };
            FuelCar Car = new FuelCar(eDoorsNum.Five, eCarColor.Red, 5.0f, 9.2f, eFuelType.Octan95, "Mazda Mx5", "6817799", whells);
            Console.WriteLine(Car);
            Console.Read();

        }
    }
}
