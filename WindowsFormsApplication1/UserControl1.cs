using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(int month)
        {
            InitializeComponent();
            DateTime test = new DateTime(DateTime.Now.Year, month, 1);
            labelmain.Text = test.ToString("MMMM");

            List<Label> ggg = new List<Label>();
            ggg.Add(label1);
            ggg.Add(label2);
            ggg.Add(label3);
            ggg.Add(label4);
            ggg.Add(label5);
            ggg.Add(label6);
            ggg.Add(label7);
            ggg.Add(label8);
            ggg.Add(label9);
            ggg.Add(label10);
            ggg.Add(label11);
            ggg.Add(label12);
            ggg.Add(label13);
            ggg.Add(label14);
            ggg.Add(label15);
            ggg.Add(label16);
            ggg.Add(label17);
            ggg.Add(label18);
            ggg.Add(label19);
            ggg.Add(label20);
            ggg.Add(label21);
            ggg.Add(label22);
            ggg.Add(label23);
            ggg.Add(label24);
            ggg.Add(label25);
            ggg.Add(label26);
            ggg.Add(label27);
            ggg.Add(label28);
            ggg.Add(label29);
            ggg.Add(label30);
            ggg.Add(label31);
            ggg.Add(label32);
            ggg.Add(label33);
            ggg.Add(label34);
            ggg.Add(label35);

            for (int i = 0; i < DateTime.DaysInMonth((DateTime.Now.Year), month); i++)
            {
                ggg[i].Text = (i + 1).ToString();


            }

            for (int i = DateTime.DaysInMonth((DateTime.Now.Year), month); i < 35; i++)
            {
                ggg[i].Visible = false;

            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           


        }

        private void y_Click(object sender, EventArgs e)
        {

        }
    }
}
