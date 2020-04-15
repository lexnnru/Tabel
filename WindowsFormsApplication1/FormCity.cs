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
    public partial class FormCity : Form
    {
        Db db = new Db();
 
        public FormCity()
        {
            InitializeComponent();

        }
        public FormCity(Point point)
        {
            InitializeComponent();
            this.Location = new Point(point.X-170, point.Y+20);

        }
        private void FormCity_Load(object sender, EventArgs e)
        {
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbCity.SelectedIndex = cbCity.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.AddCity(cbCity.Text);
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbCity.SelectedIndex = cbCity.Items.Count - 1;
            MessageBox.Show("Добавлен новый горд");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.DellCity(cbCity.Text);
            cbCity.DataSource = db.GetTableCity();
           // cbCity.DisplayMember = "City";
            MessageBox.Show("Город удален");

        }

        private void FormCity_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshCity?.Invoke();
        }
        public event Action RefreshCity;
    }
}
