using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelLibrary;

namespace Tabel
{
    public partial class Form6 : Form
    {
        Db db = new Db();
        public Form6()
        {
            InitializeComponent();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                dgReport.DataSource = db.GetReport(tbCommand.Text);
            }
            catch { MessageBox.Show("Непавильная команда"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dgReport.Rows.Count; i++)
            {
                for (int j = 0; j < dgReport.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dgReport.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
            ExcelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
        }
    }
}
