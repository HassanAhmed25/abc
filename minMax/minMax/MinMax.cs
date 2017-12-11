using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMax
{
   class MinMax
    {

        public char min(char a, char b)
        {
             if (a < b)
	        {
                return a;
	        }
             else
             {
                 return b;
             }
        }
        public int min(int a, int b)
        {
            if (a < b)
	        {
		        return a;
	        }
            else
            {
                return b;
            }
        }
        public char max(char a, char b)
        {
             if (a > b)
	        {
		        return a;
	        }
            else
	        {
                return b;
	        }
 
        }
        public int max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }


    }
}
