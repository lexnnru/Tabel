using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelLibrary;

namespace WindowsFormsApplication1
{
    public interface IMonth
    {
        event Action<DateTime> Click;
        Month GetMonth { get; }
        DateTime SelectedLabel { get; }
        void unSelect();
        void update();

    }

    public partial class Month : UserControl, IMonth
    {
        public event Action<DateTime> Click;
        public DateTime SelectedLabel { get; }
        public Month GetMonth { get { return this; } }

        private DateTime dateTime;
        private List<Label> labels;
        public DateTime date;
        List<Label> dayOfWeeks=new List<Label>();
        Label MonthName = new Label();
        public DateTime SelectedDay;
        Db db = new Db();

        public Month(DateTime date)
        {
            
            dateTime = date;
            labels = new List<Label>();
            InitializeComponent();
            InitLabels();
            Fill();
        }

        void InitLabels()
        {
            MonthName.Text = dateTime.ToString("MMMM");
            MonthName.Width = panel1.Width;
            MonthName.Height = 30 ;
            MonthName.BackColor = Color.LightGray;
            MonthName.TextAlign = ContentAlignment.MiddleCenter;
            MonthName.Location = new Point(panel1.Location.X, panel1.Location.Y-60);
            MonthName.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(MonthName);
            List<string> dayofweekList = new List<string>() { "ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС" };
            for (int i = 0; i < dayofweekList.Count; i++)
            {
                Label label = new Label() { Text = dayofweekList[i].ToString(), Width = panel1.Width / 7, Height = 30 };
                label.Location = new Point(panel1.Location.X+(i * label.Width) , panel1.Location.Y-30);
                label.BackColor = Color.LightGray;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.BorderStyle = BorderStyle.FixedSingle;
                Controls.Add(label);
                dayOfWeeks.Add(label);

            }
            for (int i = 0; i < DateTime.DaysInMonth(dateTime.Year, dateTime.Month); i++)
            {
                Label label = new Label() { Text = (i + 1).ToString(), Width = panel1.Width / 7, Height = panel1.Height / 6 };

                if (db.HoliIsThisDay(dateTime.Year, dateTime.Month, i + 1) == true)
                    label.BackColor = Color.LightCoral;
                else
                    label.BackColor = Color.LightBlue;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font(label.Font.FontFamily, 10);
                label.Click += Label_Click;
                

                label.Location = new Point((i + (int)dateTime.DayOfWeek - 1) % 7 * label.Width, (i + (int)dateTime.DayOfWeek - 1) / 7 * label.Height);
                labels.Add(label);
            }


        }
        private void Label_Click(object s, EventArgs e)
        {

            if (SelectedDay == new DateTime(1,1,0001))
            { }
            else
            {
                if (db.HoliIsThisDay(SelectedDay.Year, SelectedDay.Month, SelectedDay.Day) == true)
                    labels[SelectedDay.Day - 1].BackColor = Color.LightCoral;
                else
                    labels[SelectedDay.Day - 1].BackColor = Color.LightBlue;
            }
            ((Label)s).BackColor = Color.LightGreen;
            Label t = (Label)s;
            int tt = Convert.ToInt32(t.Text);
            SelectedDay = new DateTime(dateTime.Year, dateTime.Month, tt);
            Click?.Invoke(new DateTime(dateTime.Year, dateTime.Month, tt));
        }
        public void unSelect()
        {
            if (SelectedDay != null)
                if (db.HoliIsThisDay(SelectedDay.Year, SelectedDay.Month, SelectedDay.Day) == true)
                    labels[SelectedDay.Day - 1].BackColor = Color.LightCoral;
                else
                    labels[SelectedDay.Day - 1].BackColor = Color.LightBlue;
        }
        public void update()
        {
            //  labels[adddedDay - 1].BackColor = Color.LightCoral;
            for (int i =0; i<labels.Count; i++)
            {
                if (db.HoliIsThisDay(dateTime.Year, dateTime.Month, i + 1) == true)
                    labels[i].BackColor = Color.LightCoral;
                else
                    labels[i].BackColor = Color.LightBlue; 
            }


        }



        void Fill()
        {
            panel1.Controls.Clear();
            labels.ForEach(l =>
            {
                l.Width = panel1.Width / 7;
                l.Height = panel1.Height / 6;
                int Dow = ((int)dateTime.DayOfWeek == 0) ? 7 : (int)dateTime.DayOfWeek;
                l.Location = new Point((int.Parse(l.Text) + Dow - 2) % 7 * l.Width,
                    ((int.Parse(l.Text) + Dow - 2) / 7 * l.Height));
                var x = 1 % 7;
                panel1.Controls.Add(l);
            });

            for (int i = 0; i < dayOfWeeks.Count; i++)
            {
                dayOfWeeks[i].Width = panel1.Width / 7;
                dayOfWeeks[i].Height =30;
                dayOfWeeks[i].Location=new Point(panel1.Location.X + i*(dayOfWeeks[i].Width), panel1.Location.Y - 30);
                Controls.Add(dayOfWeeks[i]);
            }
            MonthName.Width = (panel1.Width/7)*7;
            MonthName.Height = 30;
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            Fill();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Month_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
