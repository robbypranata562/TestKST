using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SortedName
{
    public partial class Form1 : Form
    {
        ClassPopulateListName PopulateName = new ClassPopulateListName();
        CheckNameClass CheckName = new CheckNameClass();
        Check2NameClass Check2Name = new Check2NameClass();
        Check3NameClass Check3Name = new Check3NameClass();
        SortingNameClass SortName = new SortingNameClass();
        AddToDatagridviewClass AddToDatagridview = new AddToDatagridviewClass();
        ExportNameToTxtClass ExportNameToClass = new ExportNameToTxtClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Application.StartupPath;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                }
                var list = new List<string>();
                var fileStream = new FileStream(theDialog.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] data = line.Split('\n');
                        AddToDatagridview.AddData(dataGridView1,data[0]);
                        if (data[0].Split(' ').Count() == 1)
                        {
                            PopulateName.AddToList(CheckName.getName(data[0]),data[0]);
                        }
                        else if (data[0].Split(' ').Count() == 2)
                        {
                            PopulateName.AddToList(Check2Name.getName(data[0]), data[0]);
                        }
                        else
                        {
                            PopulateName.AddToList(Check3Name.getName(data[0]), data[0]);
                        }
                       
                    }
                }
                dataGridView2.DataSource = SortName.SortName(PopulateName._ListName);
                dataGridView2.Columns[0].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportNameToClass.WriteToTxt(dataGridView2);
        }
    }
}
