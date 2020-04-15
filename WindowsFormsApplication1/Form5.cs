using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TabelLibrary;
using TabelLibrary.Model;

namespace Tabel
{
    public partial class Form5 : Form
    {
        DateTime cleckedDay;
        List<IMonth> Monthes = new List<IMonth>();
        Db db = new Db();
        public Form5()
        {
            InitializeComponent();
            label6.Text = "Заполнение произвоственного календаря на " +DateTime.Now.Year.ToString()+" год";
        }
        private void Day_Click(DateTime obj)
        {
            if (cleckedDay != null)
            {
                if (obj.Month != cleckedDay.Month)
                { Monthes[cleckedDay.Month - 1].unSelect(); }
            }
            cleckedDay = obj;
            dtMonthHoli.Value = cleckedDay;

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            this.Size = new Size { Height = 700, Width = 1215 };
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 1, 1)) { Height = 200, Width = 200, Location = new Point(0, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 2, 1)) { Height = 200, Width = 200, Location = new Point(200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 3, 1)) { Height = 200, Width = 200, Location = new Point(2 * 200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 4, 1)) { Height = 200, Width = 200, Location = new Point(3 * 200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 5, 1)) { Height = 200, Width = 200, Location = new Point(4 * 200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 6, 1)) { Height = 200, Width = 200, Location = new Point(5 * 200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 7, 1)) { Height = 200, Width = 200, Location = new Point(0, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 8, 1)) { Height = 200, Width = 200, Location = new Point(200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 9, 1)) { Height = 200, Width = 200, Location = new Point(2 * 200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 10, 1)) { Height = 200, Width = 200, Location = new Point(3 * 200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 11, 1)) { Height = 200, Width = 200, Location = new Point(4 * 200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 12, 1)) { Height = 200, Width = 200, Location = new Point(5 * 200, 350) });
            Monthes.ForEach(i => {
                Controls.Add(i.GetMonth);
                i.Click += Day_Click;
            });
            Monthes.ForEach(i => {
                ;
            });

        }

        private void addHoli_Click(object sender, EventArgs e)
        {
            bool sovpadenie= false;
            DateTime addedDay = new DateTime(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month, dtMonthHoli.Value.Day);
            List<int> monthHoliday = db.GetMonthHoliday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month);
            List<int> monthHoliWorkday = db.GetWorkDayOnHoliday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month);
            if (addedDay.DayOfWeek==DayOfWeek.Saturday || addedDay.DayOfWeek == DayOfWeek.Sunday)
            {
                bool sovpadenieWhithWorkDay=false;
                monthHoliWorkday.ForEach(q =>
                {
                    if (dtMonthHoli.Value.Day == q)
                    {
                        sovpadenieWhithWorkDay = true;
                    }
                    else
                    { }
                });
                    if (sovpadenieWhithWorkDay == false)
                    { MessageBox.Show("Нельзя добавить этот день, так как он уже выходной."); }
                else
                { db.DelMonthWorkDayOnHoloday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month, dtMonthHoli.Value.Day); }
            }
            else
            {
                monthHoliday.ForEach( q=>
                {
                    if (dtMonthHoli.Value.Day == q)
                    { sovpadenie = true;
                         }
                    else
                    { }
                 } );
            if (sovpadenie==true)
                { MessageBox.Show("Нельзя добавить этот день, так как он уже выходной."); }
                else
                {
                    db.SetMonthHoliday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month, dtMonthHoli.Value.Day);
                    
                }
            }
            Monthes[dtMonthHoli.Value.Month - 1].update();

        }

        public void update()
        {
            //mcJanvary.BoldedDates = db.GetHoli(DateTime.Now.Year, 1);
            //mcFeb2.BoldedDates = db.GetHoli(DateTime.Now.Year, 2);
            //mcMarch3.BoldedDates = db.GetHoli(DateTime.Now.Year, 3);
            //mcApril4.BoldedDates = db.GetHoli(DateTime.Now.Year, 4);
            //mcMay5.BoldedDates = db.GetHoli(DateTime.Now.Year, 5);
            //mcJiun6.BoldedDates = db.GetHoli(DateTime.Now.Year, 6);
            //mcIjul7.BoldedDates = db.GetHoli(DateTime.Now.Year, 7);
            //mcAug8.BoldedDates = db.GetHoli(DateTime.Now.Year, 8);
            //mcSemp9.BoldedDates = db.GetHoli(DateTime.Now.Year, 9);
            //mcOctober10.BoldedDates = db.GetHoli(DateTime.Now.Year, 10);
            //mcNovember11.BoldedDates = db.GetHoli(DateTime.Now.Year, 11);
            //mcDecember12.BoldedDates = db.GetHoli(DateTime.Now.Year, 12);

        }
        private void DelHoli_Click(object sender, EventArgs e)
        {
            DateTime deltedDay = new DateTime(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month, dtMonthHoli.Value.Day);

            List<int> monthHoliday = db.GetMonthHoliday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month);
            if (deltedDay.DayOfWeek == DayOfWeek.Saturday || deltedDay.DayOfWeek == DayOfWeek.Sunday)
            {
                db.SetMonthWorkDayOnHoloday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month, dtMonthHoli.Value.Day);
         

            }
            else
            {
                db.DelMonthHoliday(dtMonthHoli.Value.Year, dtMonthHoli.Value.Month, dtMonthHoli.Value.Day);
            }

            
        }

       
        private void btUpload_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.json";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "Производственный календарь на " + DateTime.Now.Year + " год";
            saveFileDialog1.Filter = ("File Json(*.json)|*.json|All files(*.*)|*.*");
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            TabelLibrary.Model.HoliYear hy = new TabelLibrary.Model.HoliYear(DateTime.Now.Year);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(hy);
            StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write));
            sw.Write(json);
            sw.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void btDownload_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = ("File Json(*.json)|*.json|All files(*.*)|*.*");
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                db.ClearholiTable();
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string filename = openFileDialog1.FileName;
                string json = System.IO.File.ReadAllText(filename);
                //HoliYear hy = new HoliYear(DateTime.Now.Year);
                HoliYear hy  = serializer.Deserialize<HoliYear>(json);
                for (int i =0; i<=hy.HoliYea.Count-1; i++)
                {
                    db.SetMonthHoliday(hy.HoliYea[i].ToLocalTime().Year, hy.HoliYea[i].ToLocalTime().Month, hy.HoliYea[i].ToLocalTime().Day);
                }
                for (int i = 0; i <= hy.HoliWorkYea.Count-1; i++)
                {
                    db.SetMonthWorkDayOnHoloday(hy.HoliWorkYea[i].Year, hy.HoliWorkYea[i].Month, hy.HoliWorkYea[i].Day);
                }

            }


            Monthes[dtMonthHoli.Value.Month - 1].update();
            Monthes.ForEach(q => { q.update(); }
                );
        }
    }
}
