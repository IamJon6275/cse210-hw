using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine("");

        //string concatenation
        //Console.WriteLine("Your name is " + lname + ", " + fname + " " + lname);

        //string interpolation
        Console.WriteLine($"Your name is {lname}, {fname} {lname}");

        //string formatting
        //Console.WriteLine("Your name is {0}, {1} {0}", lname, fname);
    }
}