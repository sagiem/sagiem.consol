using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_12
{
    public class Frukt
    {
        public string name { get; set; }
        public int mass { get; set; }
        public int calories { get; set; }


        public Frukt(string name, int mass, int calories)
        {
            this.name = name;
            this.mass = mass;
            this.calories = calories;
        }
    }

    
}
