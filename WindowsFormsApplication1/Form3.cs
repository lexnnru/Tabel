using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TabelLibrary;
using System.Web.Script.Serialization;
using System.IO;
using TabelLibrary.Data;
using System.Threading;
using System.Data;
using TabelLibrary.Model.Data;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Db db = new Db();
        private DateTime timebuf;
        public int selelectedRow;
        public string mail;
        public string subject;
        public string message;
        List<PGVR> listpgvr;



        public Form3()
        {
            InitializeComponent();
            timebuf = dtMain.Value;
            this.ShowInTaskbar = false;
            btChange.Enabled = false;
            btDelete.Enabled = false;
            SendForm Send = new SendForm();
            Settings s = new Settings(new TabelLibrary.Crypto.Xor());
            s.Open();
            mail = s.saveParam.username;
            subject= s.saveParam.subject;
            message = s.saveParam.message;
            listpgvr = new List<PGVR>();
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
{
            Show();
    WindowState = FormWindowState.Normal;
}
        private void Form3_Load(object sender, EventArgs e)
        {
            
            Thread tr = new Thread(checkDay);
            tr.Start();
            btSaveAll.Enabled = true;
            dataGridViewDB.AllowUserToDeleteRows = false;
            dataGridViewDB.AllowUserToResizeColumns = false;
            dataGridViewDB.AllowUserToResizeRows = false;
            dataGridViewDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridViewDB.Columns.Add("day", "День");
            dataGridViewDB.Columns.Add("city", "Город");
            dataGridViewDB.Columns.Add("specCheck", "Спец. отметка");
            dataGridViewDB.Columns.Add("dayStart", "Начало работы");
            dataGridViewDB.Columns.Add("dayEnd", "Конец работы");
            dataGridViewDB.Columns.Add("specAchiv", "Достижения за день");
            dataGridViewDB.Columns.Add("dayDuration", "Продолжительность работы");
            dataGridViewDB.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewDB.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewDB.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewDB.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewDB.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewDB.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewDB.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;


            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);
            int i = 0;
            DateTime[] list  = db.GetHoli(dtMain.Value.Year, dtMain.Value.Month);
            Rows.ForEach(q =>
            {
                TimeSpan dinnerHour = new TimeSpan(0, 48, 0);
                if (q.specCheck == "ком." || db.HoliIsThisDay(dtMain.Value.Year, dtMain.Value.Month, q.daynumber.Day) == true)
                { dinnerHour = new TimeSpan(0, 0, 0); }
                else { dinnerHour = new TimeSpan(0, 48, 0); }

                if (q.dayDuration.Duration() < dinnerHour)
                { dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration()); }
                else
                { dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration() - dinnerHour); }
                for (int j =0; j<list.Length; j++ )
                {
                    if (q.daynumber.Day == list[j].Day)
                    {
                        dataGridViewDB.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                i++;
            });
            cbSpec.DataSource = db.GetTableSpecCheck();
            cbSpec.DisplayMember = "SpecCheck";
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbCity.SelectedIndex = cbCity.Items.Count - 1;
            
            
            DataTable dataTable = db.GetTablePGVR();
            for (int j = 0; j < dataTable.Rows.Count; j++)
            { listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            cbPGVR.DataSource = listpgvr;
            dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "HH:mm";
            dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "HH:mm";
            dataGridViewDB.Columns[0].Width = 70;
            dataGridViewDB.Columns[1].Width = 120;
            dataGridViewDB.Columns[2].Width = 50;
            dataGridViewDB.Columns[3].Width = 60;
            dataGridViewDB.Columns[4].Width = 60;
            dataGridViewDB.Columns[5].Width = 400;
            dataGridViewDB.Columns[6].Width = 120;
            dataGridViewDB.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewDB.AutoResizeColumnHeadersHeight();
            //dataGridViewDB.Data
            this.WindowState = FormWindowState.Maximized;
            int x = dataGridViewDB.RowCount - 2;
            int lastday;
            if (x == -1) lastday = 0;
            else lastday = (Convert.ToDateTime(dataGridViewDB[0, x].Value)).Day;
            if (dtMain.Value.DayOfWeek == DayOfWeek.Saturday || dtMain.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dtStart.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                dtEnd.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                tbSpecAch.Text = "";
            }
            else
            {
                dtStart.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hStart, Properties.Settings.Default.minStart, 0);
                dtEnd.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hEnd, Properties.Settings.Default.minEnd, 0);
                cbCity.Text = Properties.Settings.Default.city;
                cbSpec.Text = Properties.Settings.Default.specCheck;
                tbSpecAch.Text = Properties.Settings.Default.specAchiv;
            }
            if (lastday < DateTime.DaysInMonth( DateTime.Now.Year, DateTime.Now.Month))
            { dtMain.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastday + 1); }
            else { dtMain.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastday); }
            dataGridViewDB.Rows[dataGridViewDB.Rows.Count-1].Selected = true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            db.AddCity(cbCity.Text);



            int lastday;
            if (dataGridViewDB.RowCount == 1)
            lastday = 0;
            else
            lastday = (Convert.ToDateTime(dataGridViewDB[0, dataGridViewDB.RowCount-2].Value)).Day;
            
            if (((lastday == 0) & (dtMain.Value.Day == 1)) || (dtMain.Value.Day == lastday + 1))
            {
                db.year = dtMain.Value.Year;
                db.month = dtMain.Value.Month;
                db.day = dtMain.Value.Day;
                db.hStart = dtStart.Value.Hour;
                db.minStart = dtStart.Value.Minute;
                db.hEnd = dtEnd.Value.Hour;
                db.minEnd = dtEnd.Value.Minute;
                db.specCheck = cbSpec.Text;
                db.specAchiv = tbSpecAch.Text;
                db.city = cbCity.Text;
                db.AddAllRows();
                dataGridViewDB.Rows.Clear();

                cbCity.DataSource = db.GetTableCity();
                cbCity.DisplayMember = "City";

                List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);
                int i = 0;
                Rows.ForEach(q =>
                {
                    
                    TimeSpan dinnerHour = new TimeSpan(0, 48, 0);
                    if (q.specCheck == "ком." || db.HoliIsThisDay(dtMain.Value.Year, dtMain.Value.Month, q.daynumber.Day) == true)
                    { dinnerHour = new TimeSpan(0, 0, 0); }
                    else { dinnerHour = new TimeSpan(0, 48, 0); }
                    
                    if (q.dayDuration.Duration()< dinnerHour)
                    { dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration()); }
                    else
                    { dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration() - dinnerHour); }
                   
                    if (db.HoliIsThisDay(dtMain.Value.Year, dtMain.Value.Month, q.daynumber.Day) == true)
                    {
                        dataGridViewDB.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                    else
                    {
                    }
                    i++;
                });
                dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 1].Selected = true;
                if ( dtMain.Value.Day<DateTime.DaysInMonth(dtMain.Value.Year, dtMain.Value.Month))
                {
                    dtMain.Value = new DateTime(dtMain.Value.Year, dtMain.Value.Month, dtMain.Value.Day + 1);
                }

                if (db.HoliIsThisDay(dtMain.Value.Year, dtMain.Value.Month, dtMain.Value.Day)==true)
                {
                    dtStart.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                    dtEnd.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                    tbSpecAch.Text = "";
                    cbCity.Text = Properties.Settings.Default.city;
                    cbSpec.Text = Properties.Settings.Default.specCheck;
                }
                else
                {
                    dtStart.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hStart, Properties.Settings.Default.minStart, 0);
                    dtEnd.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hEnd, Properties.Settings.Default.minEnd, 0);
                    cbCity.Text = Properties.Settings.Default.city;
                    cbSpec.Text = Properties.Settings.Default.specCheck;
                    tbSpecAch.Text = Properties.Settings.Default.specAchiv;

                }

            }
            else if (lastday == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            { MessageBox.Show("Табель текущего месяца закончен"); }
            else
            { MessageBox.Show("Неверная последовательность заполения табеля! " + "\r \n" + "          Дни вводятся строго последовательно!"); }

            //cbCity.SelectedIndex = Properties.Settings.Default.cityIndex;
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.BalloonTipTitle = "Программа учета табельного времени спрятана";
            notifyIcon1.BalloonTipText = "В любое время вы можете продолжить работу по внесению данных в табель";
            notifyIcon1.ShowBalloonTip(2000);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (timebuf.Month == ((DateTimePicker)sender).Value.Month && timebuf.Year == ((DateTimePicker)sender).Value.Year)
            {
                timebuf = ((DateTimePicker)sender).Value;
                return;
            }
            timebuf = ((DateTimePicker)sender).Value;
            dataGridViewDB.Rows.Clear();
            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);
            int i = 0;
            DateTime[] list = db.GetHoli(dtMain.Value.Year, dtMain.Value.Month);
            Rows.ForEach(q =>
            {
                TimeSpan dinnerHour = new TimeSpan(0, 48, 0);
                if (q.specCheck == "ком.")
                { dinnerHour = new TimeSpan(0, 0, 0); }
                for (int m = 0; m < list.Length; m++)
                {
                    if (q.daynumber.ToShortDateString() == list[m].ToShortDateString())
                    { dinnerHour = new TimeSpan(0, 0, 0); }
                }
                dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration() - dinnerHour);
                for (int j = 0; j < list.Length; j++)
                {
                    if (q.daynumber.Day == list[j].Day)
                    {
                        dataGridViewDB.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                i++;
            });
            cbSpec.DataSource = db.GetTableSpecCheck();
            cbSpec.DisplayMember = "SpecCheck";
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbCity.SelectedIndex = cbCity.Items.Count - 1;
            dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "HH:mm";
            dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "HH:mm";
        }
        private void btAddCity_Click(object sender, EventArgs e)
        {

            db.AddCity(cbCity.Text);
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbCity.SelectedIndex = cbCity.Items.Count-1;
        }
        private void btDelCity_Click(object sender, EventArgs e)
        {
            db.DellCity(cbCity.Text);
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
        }
        private void dataGridViewDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btSaveAll.Enabled = false;
            //btDelete.Enabled = false;
            if (dataGridViewDB.CurrentCell.RowIndex == dataGridViewDB.RowCount - 1)
            {
                int lastday;
                btSaveAll.Enabled = true;
                btChange.Enabled = false;
                btDelete.Enabled = false;
                
                if (dataGridViewDB.RowCount == 1)
                    lastday = 0;
                else
                    lastday = (Convert.ToDateTime(dataGridViewDB[0, dataGridViewDB.RowCount - 2].Value)).Day;
                if (lastday < DateTime.DaysInMonth(dtMain.Value.Year, dtMain.Value.Month))
                {
                    dtMain.Value = new DateTime(dtMain.Value.Year, dtMain.Value.Month, lastday + 1);
                }
                else
                {
                    dtMain.Value = new DateTime(dtMain.Value.Year, dtMain.Value.Month, lastday);
                }



                if (db.HoliIsThisDay(dtMain.Value.Year, dtMain.Value.Month, dtMain.Value.Day) == true)
                        
                {
                    dtStart.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                    dtEnd.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                    tbSpecAch.Text = "";
                    cbSpec.Text = Properties.Settings.Default.specCheck;
                    cbCity.Text = Properties.Settings.Default.city;
                }
               else
                {
                    dtStart.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hStart, Properties.Settings.Default.minStart, 0);
                    dtEnd.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hEnd, Properties.Settings.Default.minEnd, 0);
                    cbCity.Text = Properties.Settings.Default.city;
                    cbSpec.Text = Properties.Settings.Default.specCheck;
                    tbSpecAch.Text = Properties.Settings.Default.specAchiv;
                }
           }
            else
            {

               btDelete.Enabled = false;
                if (dataGridViewDB.CurrentCell.RowIndex == dataGridViewDB.RowCount - 2)
                { btDelete.Enabled = true; }
                    btChange.Enabled = true;
                btSaveAll.Enabled = false;
                dtStart.Value = DateTime.Parse(Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.CurrentRow.Index].Cells[3].Value));
                dtEnd.Value = DateTime.Parse(Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.CurrentRow.Index].Cells[4].Value));
                dtMain.Value = DateTime.Parse(Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.CurrentRow.Index].Cells[0].Value));
                cbCity.Text = Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.CurrentRow.Index].Cells[1].Value);
                cbSpec.Text = Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.CurrentRow.Index].Cells[2].Value);
                tbSpecAch.Text = Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.CurrentRow.Index].Cells[5].Value);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int lastday;
            int x = dataGridViewDB.RowCount - 2;
            if (x == -1) lastday = -1;
            else lastday = (Convert.ToDateTime(dataGridViewDB[0, x].Value)).Day;
            if (dtMain.Value.Day == lastday)
            {
                db.DelSelectedRow(dtMain.Value);
                lastday = lastday - 1;
                dataGridViewDB.Rows.Clear();
                List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);
                int i = 0;
                DateTime[] list = db.GetHoli(dtMain.Value.Year, dtMain.Value.Month);
                Rows.ForEach(q =>
                {
                    TimeSpan dinnerHour = new TimeSpan(0, 48, 0);
                    if (q.specCheck == "ком.")
                    { dinnerHour = new TimeSpan(0, 0, 0); }
                    for (int m = 0; m < list.Length; m++)
                    {
                        if (q.daynumber.ToShortDateString() == list[m].ToShortDateString())
                        { dinnerHour = new TimeSpan(0, 0, 0); }
                    }

                    dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration() - dinnerHour);
                    for (int j = 0; j < list.Length; j++)
                    {
                        if (q.daynumber.Day == list[j].Day)
                        {
                            dataGridViewDB.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        }
                    }
                    i++;
                });
            }
            else
            {
                MessageBox.Show("Удалять можно только последнее число!");
            }
            if (dataGridViewDB.Rows.Count==1)
            { dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 1].Selected = true;
                dtStart.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hStart, Properties.Settings.Default.minStart, 0);
                dtEnd.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hEnd, Properties.Settings.Default.minEnd, 0);
                cbCity.Text = Properties.Settings.Default.city;
                cbSpec.Text = Properties.Settings.Default.specCheck;
                tbSpecAch.Text = Properties.Settings.Default.specAchiv;
            }
            else
            {
                dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Selected = true;
                dtStart.Value = DateTime.Parse(Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Cells[3].Value));
                dtEnd.Value = DateTime.Parse(Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Cells[4].Value));
                dtMain.Value = DateTime.Parse(Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Cells[0].Value));
                cbCity.Text = Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Cells[1].Value);
                cbSpec.Text = Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Cells[2].Value);
                tbSpecAch.Text = Convert.ToString(dataGridViewDB.Rows[dataGridViewDB.Rows.Count - 2].Cells[5].Value);
            }
        }
        private void btChange_Click(object sender, EventArgs e)
        {
            timebuf = dtMain.Value;
            selelectedRow = dtMain.Value.Day - 1;
            db.year = timebuf.Year;
            db.month = timebuf.Month;
            db.day = timebuf.Day;
            db.hStart = dtStart.Value.Hour;
            db.minStart = dtStart.Value.Minute;
            db.hEnd = dtEnd.Value.Hour;
            db.minEnd = dtEnd.Value.Minute;
            db.specCheck = cbSpec.Text;
            db.specAchiv = tbSpecAch.Text;
            db.city = cbCity.Text;
            db.ChangeSelectedRow();
            dataGridViewDB.Rows.Clear();
            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);
            int i = 0;
            DateTime[] list = db.GetHoli(dtMain.Value.Year, dtMain.Value.Month);
            Rows.ForEach(q =>
            {
                TimeSpan dinnerHour = new TimeSpan(0, 48, 0);
                if (q.specCheck == "ком.")
                { dinnerHour = new TimeSpan(0, 0, 0); }
                for (int m = 0; m < list.Length; m++)
                {
                    if (q.daynumber.ToShortDateString() == list[m].ToShortDateString())
                    { dinnerHour = new TimeSpan(0, 0, 0); }
                }

                dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration() - dinnerHour);
                for (int j = 0; j < list.Length; j++)
                {
                    if (q.daynumber.Day == list[j].Day)
                    {
                        dataGridViewDB.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                i++;
            });
           dataGridViewDB.Rows[dtMain.Value.Day - 1].Selected = true;
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void dataGridViewDB_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btDownload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string filename = openFileDialog1.FileName;
                string json = System.IO.File.ReadAllText(filename);
                dataGridViewDB.Rows.Clear();
                List<OneDayData> Rows = serializer.Deserialize<List<OneDayData> >(json);
                Rows.ForEach((j) => { j.daynumber = j.daynumber.ToLocalTime(); j.startday = j.startday.ToLocalTime(); j.endday = j.endday.ToLocalTime(); });
                int i = 0;
                DateTime[] list = db.GetHoli(dtMain.Value.Year, dtMain.Value.Month);
                Rows.ForEach(q =>
                {
                    TimeSpan dinnerHour = new TimeSpan(0, 48, 0);
                    if (q.specCheck == "ком.")
                    { dinnerHour = new TimeSpan(0, 0, 0); }
                    for (int m = 0; m < list.Length; m++)
                    {
                        if (q.daynumber.ToShortDateString() == list[m].ToShortDateString())
                        { dinnerHour = new TimeSpan(0, 0, 0); }
                    }

                    dataGridViewDB.Rows.Add(q.daynumber.ToShortDateString(), q.city, q.specCheck, q.startday.ToShortTimeString(), q.endday.ToShortTimeString(), q.achiv, q.dayDuration.Duration() - dinnerHour);
                    for (int j = 0; j < list.Length; j++)
                    {
                        if (q.daynumber.Day == list[j].Day)
                        {
                            dataGridViewDB.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        }
                    }
                    i++;
                });
            }
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Rows.ForEach((i) => {
                i.family = Properties.Settings.Default.family;
                i.name = Properties.Settings.Default.name; i.parentName = Properties.Settings.Default.parentName;
                i.subject = subject; i.message = message; i.mail = mail; i.tabelNumber = Properties.Settings.Default.TabelNumber; i.daynumber = i.daynumber.ToUniversalTime(); i.startday = i.startday.ToUniversalTime(); i.endday = i.endday.ToUniversalTime(); });
            string json = serializer.Serialize(Rows);
            StreamWriter sw = new StreamWriter(new FileStream(Application.StartupPath + "\\Табель от "+Properties.Settings.Default.family +" табельный №" +Properties.Settings.Default.TabelNumber +" За " + DateTime.Now.ToString("MMM") +".json", FileMode.Create, FileAccess.Write));
            sw.Write(json);
            sw.Close();
            SendForm Send = new SendForm();
            Send.ShowDialog();
            

        }
        private void btUpload_Click(object sender, EventArgs e)
        {
            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Rows.ForEach((i) => {
                i.family = Properties.Settings.Default.family;
                i.name = Properties.Settings.Default.name; i.parentName = Properties.Settings.Default.parentName;
                i.subject = subject; i.message = message; i.mail = mail; i.tabelNumber = Properties.Settings.Default.TabelNumber; i.daynumber = i.daynumber.ToUniversalTime(); i.startday = i.startday.ToUniversalTime(); i.endday = i.endday.ToUniversalTime(); });
            string json = serializer.Serialize(Rows);
            StreamWriter sw = new StreamWriter(new FileStream(Application.StartupPath + "\\monthtabel" + Properties.Settings.Default.family + Properties.Settings.Default.TabelNumber + ".json", FileMode.Create, FileAccess.Write));
            sw.Write(json);
            sw.Close();
        }

        private void notifyIcon1_DoubleClick_1(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
        }
        private void btSettings_Click(object sender, EventArgs e)
        {
            Form4 defSetting = new Form4();
            defSetting.ShowDialog();
        }
        private void btReport_Click(object sender, EventArgs e)
        {
            Form6 ReportForm = new Form6();
            ReportForm.ShowDialog();

        }
        private void значенияПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void отправитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int lastday;
            if (dataGridViewDB.RowCount == 1)
                lastday = 0;
            else
                lastday = (Convert.ToDateTime(dataGridViewDB[0, dataGridViewDB.RowCount - 2].Value)).Day;
            if (DateTime.Now == Properties.Settings.Default.dayX && lastday == 15)
            {
                Send();
            }
            else
            {
                DialogResult ok = MessageBox.Show("Табель не заполнен или не пришло время отправки. Отправить?", "Внимание!", MessageBoxButtons.OKCancel);
                if (ok == DialogResult.OK)
                {
                    Send();
                }
            }
            //else if (DateTime.Now == Properties.Settings.Default.dayX && lastday == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            //{ Send(); }
            //else if (DateTime.Now.Day <= 15 && lastday < 15)
            //{
            //    DialogResult ok = MessageBox.Show("Табель не заполнен до середины месяца. Отправить?", "Внимание!", MessageBoxButtons.OKCancel);
            //    if (ok == DialogResult.OK)
            //    {
            //        Send(); 
            //   }

            //}
            //else if (DateTime.Now.Day > 15 && lastday == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) )
            //{ Send(); }
            //else
            //{
            //    DialogResult ok = MessageBox.Show("Табель не заполнен до конца месяца. Отправить?", "Внимание!", MessageBoxButtons.OKCancel);
            //    if (ok == DialogResult.OK)
            //    {
            //        Send();
            //    }
            //}
            this.Cursor = Cursors.Default;

        }
        public void Send ()
        {
            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Rows.ForEach((i) => {
                i.family = Properties.Settings.Default.family;
                i.name = Properties.Settings.Default.name; i.parentName = Properties.Settings.Default.parentName;
                i.subject = subject; i.message = message; i.mail = this.mail; i.tabelNumber = Properties.Settings.Default.TabelNumber; i.daynumber = i.daynumber.ToUniversalTime(); i.startday = i.startday.ToUniversalTime(); i.endday = i.endday.ToUniversalTime(); });
            string json = serializer.Serialize(Rows);
            //StreamWriter sw = new StreamWriter(new FileStream(Application.StartupPath + "\\Табель от " + Properties.Settings.Default.FIO + " табельный №" + Properties.Settings.Default.TabelNumber + " за " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.Year + " года" + ".json", FileMode.Create, FileAccess.Write));
            //sw.Write(json);
            File.WriteAllText(Application.StartupPath + "\\Табель от " + Properties.Settings.Default.family + " табельный №" + Properties.Settings.Default.TabelNumber + " за " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.Year + " года" + ".json", json);
            //sw.Close();
            SendForm Send = new SendForm();
            Settings s = new Settings(new TabelLibrary.Crypto.Xor());
            s.Open();

            SendMail mail = new SendMail();
            if (mail.Send(new MailSet(s.saveParam.ToString(), Application.StartupPath + "\\Табель от " + Properties.Settings.Default.family + " табельный №" + Properties.Settings.Default.TabelNumber + " за " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.Year + " года" + ".json")))
            {
                MessageBox.Show("Табель отправлен");
                this.Close();
            }
            else
            {
                MessageBox.Show(mail.Error);
                
              }
        }
        private void настройкиПочтовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 defSetting = new Form4();
            defSetting.ShowDialog();
        }
        private void почтовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Mail_settings = new Form2();
            Mail_settings.ShowDialog();
        }

        private void производственныйКалендарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 HolidaySettingsForm = new Form5();
            HolidaySettingsForm.ShowDialog();
        }
        private void консольToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void консольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 ReportForm = new Form6();
            ReportForm.ShowDialog();
        }

        private void дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.json";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "Табель за " + DateTime.Now.ToShortDateString();
            saveFileDialog1.Filter = ("File Json(*.json)|*.json|All files(*.*)|*.*");
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            List<OneDayData> Rows = db.GetTable(dtMain.Value.Year, dtMain.Value.Month);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Rows.ForEach((i) => { i.family = Properties.Settings.Default.family;
                i.name = Properties.Settings.Default.name; i.parentName = Properties.Settings.Default.parentName;
                i.subject = subject; i.message = message; i.mail = mail;
                i.tabelNumber = Properties.Settings.Default.TabelNumber; i.daynumber = i.daynumber.ToUniversalTime(); i.startday = i.startday.ToUniversalTime(); i.endday = i.endday.ToUniversalTime(); });
            string json = serializer.Serialize(Rows);
            StreamWriter sw = new StreamWriter(new FileStream(filename + Properties.Settings.Default.family + Properties.Settings.Default.TabelNumber + ".json", FileMode.Create, FileAccess.Write));
            sw.Write(json);
            sw.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void вEXELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridViewDB.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewDB.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = Convert.ToString(dataGridViewDB.Rows[i].Cells[j].Value);
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
            ExcelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
        }

        private void intranetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intranet intranet = new Intranet();
            //Intranet intranet  = new Intranet("https://intranet.sintek-nn.ru");
            intranet.ShowDialog();
           
        }

        private void справочникКомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intranet intranet = new Intranet("https://intranet.sintek-nn.ru/phone/");
            intranet.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point = cbPGVR.Location;
            FormCity formCity = new FormCity(point);

            formCity.RefreshCity += FormCity_RefreshCity;
            this.Opacity = (10);
            formCity.ShowDialog();
            
        }

        private void FormCity_RefreshCity()
        {
            cbCity.DataSource = db.GetTableCity();

        }
        private void RefreshPGVR()
        {
            listpgvr = new List<PGVR>();
            DataTable dataTable = db.GetTablePGVR();
            
            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(),
                    dataTable.Rows[j].ItemArray[2].ToString()));
            }
            cbPGVR.DataSource = listpgvr;

        }

        public void checkDay()
        {
            Db db = new Db();
            List<int> holiMonth = db.GetRealHoliMonth(DateTime.Now.Year, DateTime.Now.Month);

            int dayX=15;
            bool isitHoly = false;
            for (;;)
            {
                
                if (DateTime.Now.Day <= 15)
                {
                    dayX = 15;
                    for (int i = 15; i > 0; i--)
                    {

                        isitHoly = false;
                        for (int j=0; j<holiMonth.Count; j++)
                        { if (holiMonth[j] == i)
                            {
                                isitHoly = true;
                            }
                         }
                        if (isitHoly == true)
                        { dayX--; }
                        else if (isitHoly==false)
                        { goto end1; }

                    }
                
                }
               
                if (DateTime.Now.Day > 15)
                {
                    
                    dayX = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    for (int i = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i > 15; i--)
                    {
                        isitHoly = false;
                        for (int j = 0; j < holiMonth.Count; j++)
                        {
                            if (holiMonth[j] == i)
                            {
                                isitHoly = true;
                            }
                        }
                        if (isitHoly == true)
                        { dayX--; }
                        else if (isitHoly == false)
                        { goto end1; }

                    }

                }
            end1:;
                Properties.Settings.Default.dayX = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayX);
                if (DateTime.Now.Day==dayX)
                {
                    for (int i = 0; i <= 3; i++)
                    { Invoke(new Action(() => {showNotify(true);
                    }));
                        Thread.Sleep(1500);
                        Invoke(new Action(() => {
                            showNotify(false);
                        }));
                        Thread.Sleep(1500);
                    }
            }
                else
                {
                    Invoke(new Action(() =>
                    {
                        showNotify(false);
                    }));
                }

                Thread.Sleep(5000);
            }

        }
        public void showNotify (bool show)
        {
            if (show==true)
            {
                labelNoty.Text = "Внимание!" + '\r' + '\n' + "Сегодня необходимо отправить табель!";
                labelNoty.TextAlign = ContentAlignment.MiddleCenter;
                labelNoty.Update();
            }
            else
            { labelNoty.Text = "";
                labelNoty.Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point point = cbPGVR.Location;
            FormPGVR formPGVR = new FormPGVR(point);
            formPGVR.RefreshPGVR += RefreshPGVR;
            this.Opacity = (10);
            formPGVR.ShowDialog();
        }

        private void cbPGVR_SelectedValueChanged(object sender, EventArgs e)
        {
            tbSpecAch.Text += "ПГВР: " +listpgvr[cbPGVR.SelectedIndex].Pgvr+ " ";
        }
    }
}
