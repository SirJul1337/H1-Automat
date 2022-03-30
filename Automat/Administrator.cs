using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Administrator
    {

        public bool AdminPassword(string guess)
        {
            if (guess == "Admin12345")
            {
                return true;
            }
            return false;
        }
    }
}
