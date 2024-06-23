using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercises;

class Exercises
{
    public static void CheckValid()
    {
        Console.WriteLine("Enter a number between 1 and 10");
        int number = Convert.ToInt32(Console.ReadLine());

        string output = (number >= 1 && number <= 10) ? "Valid" : "Invalid";

        Console.WriteLine(output);

        //            if (number >=1 && number <=10)
        //            {
        //                Console.WriteLine("Valid!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid");
        //            }
    }

    /// <summary>
    /// takes two numbers from console and displays maximum 
    /// </summary>
    public static void Max()
    {
        Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        string output = num1 >= num2 ? "num1" : "num2";
        Console.WriteLine("the max is " + output);
    }

    /// <summary>
    /// ask user to enter the width and height of an image
    /// tell if image is landscape or portrait. 
    /// </summary>
    public static void ImageType()
    {
        Console.WriteLine("enter width of the image");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter height of the image");
        int height = Convert.ToInt32(Console.ReadLine());

        if (width > height)
            Console.WriteLine("the image is a landscape");
        else if (width < height)
        {
            Console.WriteLine("the image is a portrait");
        }
        else
        {
            Console.WriteLine("the image is squared");
        }
    }

    /// <summary>
    /// asks user to enter the speed limit.then the speed of car.
    ///  If the user enters a value less than the speed limit, program display Ok.
    ///  If the value is above speed limit, program calculate the number of demerit points.
    /// For every 5km/hr above the speed limit, 1 demerit points.
    /// If the number of demerit points is above 12, the program display License Suspended.
    /// </summary>
    public static void CheckSpeed()
    {
        Console.WriteLine("Enter the speed limit value");
        int speedLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the speed of the car");
        int carSpeed = Convert.ToInt32(Console.ReadLine());
        int demeritPoints = 0;

        if (carSpeed < speedLimit)
            Console.WriteLine("OK!");
        else
        {
            demeritPoints = (carSpeed - speedLimit) / 5;
            Console.WriteLine(demeritPoints);
            if (demeritPoints > 12)
                Console.WriteLine("Lincese Suspended!");
            else
                Console.WriteLine("demerit point are " + demeritPoints);
        }
    }
}