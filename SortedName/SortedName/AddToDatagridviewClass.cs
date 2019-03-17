using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SortedName
{
    class AddToDatagridviewClass
    {
        

        public void AddData(DataGridView dgv , string name)
        {
            dgv.Rows.Add(name);
        }
    }
}
