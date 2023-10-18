using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Concretes
{
    public class Menu : Product
    {
        public override string ToString()
        {
            string info = Name;
            return info;
        }
    }
}
