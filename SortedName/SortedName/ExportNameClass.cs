using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SortedName
{
    class ExportNameClass
    {

    }

    class ExportNameToTxtClass : ExportNameClass
    {
        public void WriteToTxt(DataGridView dgv)
        {
            string name = "";
            foreach (DataGridViewRow item in dgv.Rows)
            {
               
                name = name + item.Cells[1].Value.ToString() + System.Environment.NewLine;
            }
            File.WriteAllText(Application.StartupPath + "\\sorted_name.txt", name);
        }
    }
}
