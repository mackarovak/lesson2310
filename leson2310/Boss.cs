using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    class Boss:Staff
    {
        public Boss(string name, ref int lastID) : base(name, ref lastID)
        {

        }
        public Boss(string name, string surname, Staff head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
