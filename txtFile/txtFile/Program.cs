using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter wr;
            wr = new StreamWriter("data.txt", true);


            string n = string.Empty;
            int b = 0;
            string d = string.Empty;



            User_Input obj = new User_Input(n,b,d);
            n = obj.name;
            b = obj.cont;
            d = obj.add;
            string c = string.Empty;
            Console.WriteLine("Welcome To Our Place");
            Console.WriteLine("PLEASE ENTER UR NAME : " + n);
            Console.WriteLine("PLEASE ENTER UR CONTACT NO. : " + b);
            Console.WriteLine( "IF u want HOME DELIVERY, so please Enter ur address or else NO NEED !"  + c);
            if (c == "y" || c == "Y" )
            {
                Console.WriteLine("Enter Address : " + d);
                
                wr.WriteLine(n);
                wr.WriteLine(b);
                wr.WriteLine(d);

                Console.WriteLine("REGISTRATION SUCCESSFUL");
            }
            else
            {
                wr.WriteLine(n);
                wr.WriteLine(b);
                Console.WriteLine("THANKS FOR REGISTRATION !");
            }

            

        }
    }
}
