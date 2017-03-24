using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    class Pensioner :Citizen
    {
        public Pensioner(string firstname, string lastname, string passport)
            : base(firstname, lastname, passport)
        {
        }
    }
}
