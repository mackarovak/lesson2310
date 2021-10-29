using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    class Deputy_developer:Staff
    {
        public Deputy_developer(string name, ref int lastID, Staff head) : base(name, ref lastID, head)
        {

        }
        public Deputy_developer(string name, string surname, Staff head, ref int lastID) : base(name, surname, head, ref lastID)
        {

        }
    }
}
