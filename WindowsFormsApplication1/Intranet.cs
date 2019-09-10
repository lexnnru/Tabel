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
    public partial class Intranet : Form
    {
        public Intranet()
        {
            InitializeComponent();
        }

        private void Intranet_Load(object sender, EventArgs e)
        {
        }
        public Intranet (string webUrl)
        {
            InitializeComponent();
            Uri Url1 = new Uri(webUrl);
             webBrowser1.Url = Url1;
        }
    }
}
