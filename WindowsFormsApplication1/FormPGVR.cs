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
using TabelLibrary.Model.Data;

namespace WindowsFormsApplication1
{

    public partial class FormPGVR : Form
    {
        List<PGVR> listpgvr;
        Db db = new Db();
        public event Action RefreshPGVR;
        public FormPGVR()
        {
            InitializeComponent();
            //listpgvr = new List<PGVR>();
            //DataTable dataTable = db.GetTablePGVR();
            //for (int j = 0; j < dataTable.Rows.Count; j++)
            //{ listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            //List<string> pgvr = new List<string>();
            //List<string> descr = new List<string>();
            //for (int q=0; q<listpgvr.Count;q++)
            //{ pgvr.Add(listpgvr[q].Pgvr);
            //    descr.Add(listpgvr[q].Descr);
            //}
            //cbPGVRsumm.DataSource = pgvr;
            //tbDescr.Text = listpgvr[cbPGVR.SelectedIndex].Descr;
            //cbPGVRsumm.DataSource = listpgvr;

        }
        public FormPGVR(Point point)
        {
            InitializeComponent();
            this.Location = new Point(point.X - 170, point.Y + 20);
            listpgvr = new List<PGVR>();
            DataTable dataTable = db.GetTablePGVR();
            for (int j = 0; j < dataTable.Rows.Count; j++)
            { listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            List<string> pgvr = new List<string>();
            List<string> descr = new List<string>();
            for (int q = 0; q < listpgvr.Count; q++)
            {
                pgvr.Add(listpgvr[q].Pgvr);
                descr.Add(listpgvr[q].Descr);
            }
            cbPGVRsumm.DataSource = listpgvr;
            tbPGVR.Text = "";
            tbDescr.Text = "";

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            db.AddPGVR(tbPGVR.Text, tbDescr.Text);
            MessageBox.Show("Добавлен новый ПГВР " + tbPGVR.Text);
            listpgvr = new List<PGVR>();
            DataTable dataTable = db.GetTablePGVR();
            for (int j = 0; j < dataTable.Rows.Count; j++)
            { listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            List<string> pgvr = new List<string>();
            List<string> descr = new List<string>();
            for (int q = 0; q < listpgvr.Count; q++)
            {
                pgvr.Add(listpgvr[q].Pgvr);
                descr.Add(listpgvr[q].Descr);
            }
            cbPGVRsumm.DataSource = listpgvr;
            
        }

        private void FormPGVR_Load(object sender, EventArgs e)
        {
            listpgvr = new List<PGVR>();
            DataTable dataTable = db.GetTablePGVR();
            for (int j = 0; j < dataTable.Rows.Count; j++)
            { listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            List<string> pgvr = new List<string>();
            List<string> descr = new List<string>();
            for (int q = 0; q < listpgvr.Count; q++)
            {
                pgvr.Add(listpgvr[q].Pgvr);
                descr.Add(listpgvr[q].Descr);
            }
            cbPGVRsumm.DataSource = listpgvr;
            tbPGVR.Text = "";
            tbDescr.Text = "";

        }

        private void FormPGVR_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshPGVR?.Invoke();
        }

        private void cbPGVRsumm_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPGVR.Text = listpgvr[cbPGVRsumm.SelectedIndex].Pgvr;
            tbDescr.Text = listpgvr[cbPGVRsumm.SelectedIndex].Descr;
        }

    

        private void btDell_Click_1(object sender, EventArgs e)
        {
            db.DellPGVR(tbPGVR.Text);
            listpgvr = new List<PGVR>();
            DataTable dataTable = db.GetTablePGVR();
            for (int j = 0; j < dataTable.Rows.Count; j++)
            { listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            List<string> pgvr = new List<string>();
            List<string> descr = new List<string>();
            for (int q = 0; q < listpgvr.Count; q++)
            {
                pgvr.Add(listpgvr[q].Pgvr);
                descr.Add(listpgvr[q].Descr);
            }
            cbPGVRsumm.DataSource = listpgvr;
            tbPGVR.Text = "";
            tbDescr.Text = "";
        }
    }
}
