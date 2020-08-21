using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_12
{
    class Eating<T>
        where T: Frukt
    {
        public T Name { get; set; }
        public int mass { get; set; }
        public int calories { get; set; }

        public Eating(T name, int mass, int calories)
        {
            this.Name = name;
            this.mass = mass;
            this.calories = calories;
        }
    }
}
