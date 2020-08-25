using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_13
{
    class Car:Imoto

    {

        public int cool { get; set; }


        public int Move(int distace)
        {
            return distace / 1;
        }

        public int to(int distance, int time)
        {
            return distance / time*cool;
        }

     
    }
}
