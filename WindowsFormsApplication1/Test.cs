using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TestForm : Form
    {
        DateTime cleckedDay;
        List<IMonth> Monthes= new List<IMonth>();
        public TestForm()
        {
            InitializeComponent();
            

            
        }
        private void Day_Click(DateTime obj)
        {
            if (cleckedDay!=null)
            { if (obj.Month != cleckedDay.Month)
                { Monthes[cleckedDay.Month - 1].unSelect(); }
            }
            cleckedDay = obj;

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size { Height = 700, Width = 1215 };

            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 1, 1)) { Height = 200, Width = 200, Location = new Point(0, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 2, 1)) { Height = 200, Width = 200, Location = new Point(200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 3, 1)) { Height = 200, Width = 200, Location = new Point(2*200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 4, 1)) { Height = 200, Width = 200, Location = new Point(3*200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 5, 1)) { Height = 200, Width = 200, Location = new Point(4*200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 6, 1)) { Height = 200, Width = 200, Location = new Point(5*200, 130) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 7, 1)) { Height = 200, Width = 200, Location = new Point(0, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 8, 1)) { Height = 200, Width = 200, Location = new Point(200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 9, 1)) { Height = 200, Width = 200, Location = new Point(2 * 200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 10, 1)) { Height = 200, Width = 200, Location = new Point(3 * 200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 11, 1)) { Height = 200, Width = 200, Location = new Point(4 * 200, 350) });
            Monthes.Add(new Month(new DateTime(DateTime.Now.Year, 12, 1)) { Height = 200, Width = 200, Location = new Point(5 * 200, 350) });
            Monthes.ForEach(i => { Controls.Add(i.GetMonth);
                i.Click += Day_Click;
            });
            
        }
    }
}
