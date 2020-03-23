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

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        Db db = new Db();
        public Form4()
        {
            InitializeComponent();
            tbFamily.Text = Properties.Settings.Default.family;
            tbName.Text = Properties.Settings.Default.name;
            tbParentName.Text = Properties.Settings.Default.parentName;
            tbTabelNumber.Text = Properties.Settings.Default.TabelNumber;
            
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
            dtStart.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hStart, Properties.Settings.Default.minStart, 0);
            dtEnd.Value = new DateTime(1753, 1, 1, Properties.Settings.Default.hEnd, Properties.Settings.Default.minEnd, 0);
            cbCity.Text = Properties.Settings.Default.city;
            cbSpec.Text = Properties.Settings.Default.specCheck;
            tbSpecAch.Text = Properties.Settings.Default.specAchiv;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
                Properties.Settings.Default.family = tbFamily.Text;
            Properties.Settings.Default.name = tbName.Text;
            Properties.Settings.Default.parentName = tbParentName.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.TabelNumber = tbTabelNumber.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.hStart = dtStart.Value.Hour;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.minStart = dtStart.Value.Minute;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.hEnd = dtEnd.Value.Hour;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.minEnd = dtEnd.Value.Minute;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.specCheck = cbSpec.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.specAchiv = tbSpecAch.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.city = cbCity.Text;
            Properties.Settings.Default.Save();
            db.AddCity(cbCity.Text);
            Properties.Settings.Default.cityIndex = cbCity.SelectedIndex;

            //if (cbHolidays.Checked == true)
            //{
            //    Properties.Settings.Default.cbHolidays = 1;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.cbHolidays = 0;
            //    Properties.Settings.Default.Save();
            //}

            // MessageBox.Show(Properties.Settings.Default.TabelNumber);
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

        //private void cbHolidays_CheckedChanged(object sender, EventArgs e)
        //{

        //    //if (cbHolidays.Checked == true)
        //    //{
        //    //    Properties.Settings.Default.cbHolidays = 1;
        //    //    Properties.Settings.Default.Save();
        //    //}
        //    //else
        //    //{
        //    //    Properties.Settings.Default.cbHolidays = 0;
        //    //    Properties.Settings.Default.Save();
        //    //}
        //    //if (cbHolidays.Checked == true)
        //    //{
        //    //    db.year = 1753;
        //    //    db.month = 1;
        //    //    db.day = 2;
        //    //    db.hStart = dtStart.Value.Hour;
        //    //    db.minStart = dtStart.Value.Minute;
        //    //    db.hEnd = dtEnd.Value.Hour - 1;
        //    //    db.minEnd = dtEnd.Value.Minute;
        //    //    db.specCheck = cbSpec.Text;
        //    //    db.specAchiv = "1";
        //    //    db.city = cbCity.Text;
        //    //    db.ChangeSelectedRow();
        //    //}
        //    //else
        //    //{
        //    //    db.year = 1753;
        //    //    db.month = 1;
        //    //    db.day = 2;
        //    //    db.hStart = dtStart.Value.Hour;
        //    //    db.minStart = dtStart.Value.Minute;
        //    //    db.hEnd = dtEnd.Value.Hour - 1;
        //    //    db.minEnd = dtEnd.Value.Minute;
        //    //    db.specCheck = cbSpec.Text;
        //    //    db.specAchiv = "0";
        //    //    db.city = cbCity.Text;
        //    //    db.ChangeSelectedRow();
        //    //}
        //}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 HolidaySettingsForm = new Form5();
            HolidaySettingsForm.ShowDialog();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
