using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class A
    {
        public string Name { get; set; }
        public void Show1() 
        {
            Console.WriteLine("I am Parent method show1");
        }
    }

    public class B : A
    { 
    
    }



    class Program
    {
        static void Main(string[] args)
        {
            B c = new B();
            c.Show1();
            c.Name = "Kenan";
        
        }
    }
}
