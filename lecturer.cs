using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{

    public class Lecturer : person
    {
  
        public string Name;
            public new void desc()
            {
                Console.WriteLine("I am a lecturer.");
            
            }
        }
    
}
