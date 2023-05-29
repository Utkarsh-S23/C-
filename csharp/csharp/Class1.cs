using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Class1
    {
        public string name = "xyz";
        // access modifier
        private int health = 49;

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int h)
        {
            health = h;
        }
    }
}
