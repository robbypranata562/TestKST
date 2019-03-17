using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedName
{
    class SortingNameClass
    {
     
        public List<ListName> SortName(List<ListName> _ListName)
        {
            return _ListName.OrderBy(x => x.NameSorting).ToList();
        }
    }
}
