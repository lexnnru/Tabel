using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabel;
using TabelLibrary;

namespace Tabel_client
{
    public partial class StartupForm : Form
    {
        Widget widget;
        Form3 Form3;
        DateTime LocalDate;
        Db db;
        bool CanLaunchWidget;

        public StartupForm()
        {
            InitializeComponent();
            widget = new Widget();
            db = new Db();
            Form3 = new Form3();
            IReadOnlyCollection<TimeZoneInfo> timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
            if (Tabel_client.Properties.Settings.Default.selectedTimeZone == "")
            {
                LocalDate = DateTime.Now;
            }
            else
            {
                TimeZoneInfo obj = timeZoneInfos.ElementAt(Convert.ToInt32(Tabel_client.Properties.Settings.Default.selectedTimeZone));
                DateTime dt = TimeZoneInfo.ConvertTime(DateTime.Now, obj);
                LocalDate = dt;
            }
            CanLaunch();
        }
        public void CanLaunch()
        {
            List<OneDayData> monthODD = db.GetTable(LocalDate.Year, LocalDate.Month);
            if (monthODD.Count > 0)
            {
                if (monthODD[monthODD.Count - 1].daynumber.AddDays(1) == LocalDate)
                {

                    widget.Show();
                }
                else
                {
                    CanLaunchWidget = false;
                }
            }
            else
            {
                if (LocalDate.Day == 1)
                {
                    CanLaunchWidget = true;
                    widget.Show();
                }
                else
                {
                    CanLaunchWidget = false;
                }

            }
        }

        private void StartupForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CMExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void виджетToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CanLaunch();
                if (CanLaunchWidget==true)
                {
                if (widget.IsDisposed == false)
                { widget.Show(); }
                else
                {
                    widget = new Widget();
                    widget.Show();
                }
                
                }
                else
            {
                MessageBox.Show("Внимание! Запуск виджета возможен только при условии " +
                        "заполнения табеля за предыдущие дни месяца, либо табель за сегодня уже заполнен");
            }
                
            
            
        }

        private void полнаяВерсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3.Show();
        }
    }
}
