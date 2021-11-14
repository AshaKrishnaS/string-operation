using System;

namespace stringoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "asha";
            string lname = "krishna";
            //finding length
            Console.WriteLine(fname.Length);
            //concatination
            string name = fname + lname;
            Console.WriteLine(name);
            //interpolation
            string name1=$"My full name is :{ fname} { lname}";
            Console.WriteLine(name1);

        }
    }
}
