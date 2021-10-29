using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    class Chief_among_developers:Staff
    {
        public Chief_among_developers()
        {

        }
        public Chief_among_developers(string name, ref int lastID, Staff head) : base(name, ref lastID, head)
        {

        }
        public Chief_among_developers(string name, string surname, Staff head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
