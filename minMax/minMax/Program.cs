using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMax
{
    class Program
    {
        static void Main(string[] args)
        {

            MinMax obj = new MinMax();
            Console.WriteLine(obj.max(28, 29));
            Console.WriteLine(obj.max('a','c')); 
            Console.WriteLine(obj.min(8, 9));
            Console.WriteLine(obj.min('d','f'));        
        }
    }
}
