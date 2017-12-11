using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFile
{
    class User_Input
    {
        string userName;
        int userContact;
        string userAddress;

        public User_Input(string name, int cont, string add)
        {
            this.userName = name;
            this.userContact = cont;
            this.userAddress = add;
        }

        public string name
        {
            set { name = value; }
            get { return name; }
        }

       public int cont
        {
            set { cont = value; }
            get { return cont; }
        }

        public string add
        {
            set { add = value; }
            get { return add; }
        }
    }
}
