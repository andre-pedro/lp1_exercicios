using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public abstract class Character
    {
        // Property readonly
        public string Name { get; }

        // Method that chooses a direction
        public abstract char Move();
    }
}
