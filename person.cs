using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   sealed public class person
    {
        public person() { }
        public person(string Name, int NoofEyes, int Height, string FaceColor)
        {
            name = Name;
            noofEyes = NoofEyes;
            height = Height;
            faceColor = FaceColor;
        }


        public string name { get; set; }
    public int noofEyes { get; set; }
    public int height { get; set; }
    public string faceColor { get; set; }
    public void lunch()
    {
        Console.WriteLine("I usually have samosa in lunch.");
    }
    public void myColor()
    {
        Console.WriteLine("My face color is " + faceColor + ".");
    }
    public void desc()
    {
        Console.WriteLine("My name is " + name + ".");
        Console.WriteLine("I have " + noofEyes + " eyes.");
        Console.WriteLine("I am " + height + " feet tall.");
    }
}

    }
