using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Driver : person
    {
        public Driver(string Name, int NoofEyes, int Height, string FaceColor) : base(Name, NoofEyes, Height, FaceColor)
   {
            }
    public string Dlicense;
            public int age;
            public new void desc()
            {
                Console.WriteLine(name);
         // base.myDesc();
            }
        }
       
    
}

