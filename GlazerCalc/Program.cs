using System;
using System.Data;
class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;

        string widthString, heightString;

        Console.WriteLine(" Lets calcualte the  area of  wood and glass to fit a window");

        Console.WriteLine("Enter the width");

        widthString = Console.ReadLine();

        width= double.Parse(widthString);


        Console.WriteLine("Enter the the height");

        heightString=Console.ReadLine();
    
        height= double.Parse(heightString);

         woodLength= 2* (width +height) *3.25;

        glassArea= 2* ( width+ height) * 3.25;


        Console.WriteLine($"The length of the wood is " + woodLength+"feet");

        Console.WriteLine($"The area of the glass is "+ glassArea +"squaremetres");


    }
}