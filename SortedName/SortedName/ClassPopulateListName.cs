using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedName
{
    public class ListName
    {
        public string NameSorting { get; set; }
        public string Name { get; set; }
    }
    
    class ClassPopulateListName
    {
        public List<ListName> _ListName = new List<ListName>();

        public void AddToList(string _nameSorting , string _fullName)
        {
            var _nameAdded = new ListName();
            _nameAdded.NameSorting = _nameSorting;
            _nameAdded.Name = _fullName;
            _ListName.Add(_nameAdded);
        }

    }
}
