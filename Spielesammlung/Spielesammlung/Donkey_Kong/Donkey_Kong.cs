using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Donkey_Kong
    {
        public int aktuellesLevel { get; set; } = 1;

        public Donkey_Kong()
        {

        }

        public Spielfeld Donkey_Kong_Start()
        {
            return (new Spielfeld());
        }
    }
}
