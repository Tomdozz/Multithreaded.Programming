using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Customer
    {
        //vip true/false, i exit kolla om den kan plocka från ap till cp
        //Samma tillbaka
        bool vip;
        int timeInPool;
        int place;
        Random random = new Random();

        public Customer(int place, bool vip)
        {
            this.place = place;
            this.vip = vip;
            timeInPool = random.Next(30, 1500);
        }
    }
}
