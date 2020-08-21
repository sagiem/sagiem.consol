using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_12
{
    public class Apple : Frukt
    {
        public Apple(string name, int mass, int calories):base (name,mass,calories)
        {
            this.name = name;
            this.mass = mass;
            this.calories = calories;
        }

    }
}
