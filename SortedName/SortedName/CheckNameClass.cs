using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedName
{
    class CheckNameClass
    {
        public virtual string getName(string Name)
        {
            return Name;
        }
    }

    class Check2NameClass : CheckNameClass
    {
        public override string getName(string Name)
        {
            return base.getName(Name.Split(' ')[1]);
        }
    }

    class Check3NameClass : CheckNameClass
    {
        public override string getName(string Name)
        {
            return base.getName(Name.Split(' ')[2]);
        }
    }
}
