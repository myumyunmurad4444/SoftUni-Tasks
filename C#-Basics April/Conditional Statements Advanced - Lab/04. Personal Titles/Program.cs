﻿using System.ComponentModel.Design;

double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();
if (age >= 16)
{
    if (gender == "m")
    {
        Console.WriteLine("Mr.");

    }
    else if(gender == "f")
    {
        Console.WriteLine("Ms.");
    }

}
else if (age < 16)
{
    if (gender == "m")
    {
        Console.WriteLine("Master");
    }
    else if (gender == "f")
    {
        Console.WriteLine("Miss");
    }
}