using System.Data;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using ExcelObj =  Microsoft.Office.Interop.Excel;

namespace Lab05
{

    public partial class Form1 : Form
    {
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;
        //Microsoft.Office.Interop.Excel.DataTable dt;
        System.Data.DataTable dt = new System.Data.DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                workbook = app.Workbooks.Open(ofd.FileName);
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dt.AcceptChanges();
                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }
                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
                dataGridView1.DataSource = dt;
                app.Quit();
            }
            else
            {
                MessageBox.Show("�� �� ������� ���� ��� ��������",
                "�������� ������...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        //{
            
        //}
    }
}
