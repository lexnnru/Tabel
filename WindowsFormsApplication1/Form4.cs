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
using Tabel_client;

namespace Tabel
{
    public partial class Form4 : Form
    {
        Db db = new Db();
        public Form4()
        {
            InitializeComponent();
            tbFamily.Text = Tabel_client.Properties.Settings.Default.family;
            tbName.Text = Tabel_client.Properties.Settings.Default.name;
            tbParentName.Text = Tabel_client.Properties.Settings.Default.parentName;
            tbTabelNumber.Text = Tabel_client.Properties.Settings.Default.TabelNumber;
            TimeZoneInfo tzLocal = TimeZoneInfo.Local;
            cbTimeZone.DataSource=TimeZoneInfo.GetSystemTimeZones();
            if (Tabel_client.Properties.Settings.Default.selectedTimeZone == "")
            { cbTimeZone.SelectedItem = tzLocal; }
            else { cbTimeZone.SelectedIndex = Convert.ToInt32(Tabel_client.Properties.Settings.Default.selectedTimeZone); }           
            TimeSpan LocalUtcOffset=  tzLocal.BaseUtcOffset;
            //TimeZoneInfo.ConvertTime(DateTime, cbTimeZone.SelectedItem);


        }


        private void Настройки_Load(object sender, EventArgs e)
        {
            cbSpec.DataSource = db.GetTableSpecCheck();
            cbSpec.DisplayMember = "SpecCheck";
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCity.SelectedIndex = cbCity.Items.Count - 1;
            dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "HH:mm";
            dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "HH:mm";
            dtStart.Value = new DateTime(1753, 1, 1, Tabel_client.Properties.Settings.Default.hStart, Tabel_client.Properties.Settings.Default.minStart, 0);
            dtEnd.Value = new DateTime(1753, 1, 1, Tabel_client.Properties.Settings.Default.hEnd, Tabel_client.Properties.Settings.Default.minEnd, 0);
            cbCity.Text = Tabel_client.Properties.Settings.Default.city;
            cbSpec.Text = Tabel_client.Properties.Settings.Default.specCheck;
            tbSpecAch.Text = Tabel_client.Properties.Settings.Default.specAchiv;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
                Tabel_client.Properties.Settings.Default.family = tbFamily.Text;
            Tabel_client.Properties.Settings.Default.name = tbName.Text;
            Tabel_client.Properties.Settings.Default.parentName = tbParentName.Text;
            Tabel_client.Properties.Settings.Default.TabelNumber = tbTabelNumber.Text;
            Tabel_client.Properties.Settings.Default.hStart = dtStart.Value.Hour;
            Tabel_client.Properties.Settings.Default.minStart = dtStart.Value.Minute;
            Tabel_client.Properties.Settings.Default.hEnd = dtEnd.Value.Hour;
            Tabel_client.Properties.Settings.Default.minEnd = dtEnd.Value.Minute;
            Tabel_client.Properties.Settings.Default.specCheck = cbSpec.Text;
            Tabel_client.Properties.Settings.Default.specAchiv = tbSpecAch.Text;
            Tabel_client.Properties.Settings.Default.city = cbCity.Text;
            Tabel_client.Properties.Settings.Default.selectedTimeZone = cbTimeZone.SelectedIndex.ToString();
            db.AddCity(cbCity.Text);
            Tabel_client.Properties.Settings.Default.cityIndex = cbCity.SelectedIndex;
            Tabel_client.Properties.Settings.Default.Save();

            //if (cbHolidays.Checked == true)
            //{
            //    Tabel_client.Properties.Settings.Default.cbHolidays = 1;
            //    Tabel_client.Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Tabel_client.Properties.Settings.Default.cbHolidays = 0;
            //    Tabel_client.Properties.Settings.Default.Save();
            //}

            // MessageBox.Show(Tabel_client.Properties.Settings.Default.TabelNumber);
            //db.year = 1753;
            //db.month = 1;
            //db.day = 1;
            //db.hStart = dtStart.Value.Hour;
            //db.minStart = dtStart.Value.Minute;
            //db.hEnd = dtEnd.Value.Hour;
            //db.minEnd = dtEnd.Value.Minute;
            //db.specCheck = cbSpec.Text;
            //db.specAchiv = tbSpecAch.Text;
            //db.city = cbCity.Text;
            //db.ChangeSelectedRow();
            //if (cbHolidays.Checked == true)
            //{
            //    db.year = 1753;
            //    db.month = 1;
            //    db.day = 2;
            //    db.specAchiv = "1";
            //    db.ChangeSelectedRow();

            //}
            //else
            //{
            //    db.year = 1753;
            //    db.month = 1;
            //    db.day = 2;
            //    db.specAchiv = "0";
            //    db.ChangeSelectedRow();

            //}
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 HolidaySettingsForm = new Form5();
            HolidaySettingsForm.ShowDialog();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Point point = btSity.Location;
            FormCity formCity = new FormCity(point);

            formCity.RefreshCity += FormCity_RefreshCity;
            this.Opacity = (10);
            formCity.ShowDialog();
        }
        private void FormCity_RefreshCity()
        {
            cbCity.DataSource = db.GetTableCity();
        }
    }
}
