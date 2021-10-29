using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    class Chief_among_the_system_engineers:Staff
    {
        public Chief_among_the_system_engineers()
        {

        }
        public Chief_among_the_system_engineers(string name,ref int lastID, Staff head): base (name,ref lastID, head)
        {

        }
        public Chief_among_the_system_engineers(string name, string surname, Staff head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
