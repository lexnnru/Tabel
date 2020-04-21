using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabel;
using TabelLibrary;
using TabelLibrary.Model.Data;
using Timer = System.Windows.Forms.Timer;

namespace Tabel_client
{
    public partial class Widget : Form
    {
        Db db = new Db();
        Form3 Form3;
        public System.Timers.Timer timerStartTime = new System.Timers.Timer();
        public System.Timers.Timer timerEndTime = new System.Timers.Timer();
        List<PGVR> listpgvr;
        DateTime LocalDate;

        public Widget()
        {
            InitializeComponent();
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
            listpgvr = new List<PGVR>();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            tbSpecAchiv.GotFocus += TbSpecAchiv_GotFocus;
            tbSpecAchiv.LostFocus += TbSpecAchiv_LostFocus;
            cbCity.DataSource = db.GetTableCity();
            cbCity.DisplayMember = "City";
            cbSpecCheck.DataSource = db.GetTableSpecCheck();
            cbSpecCheck.DisplayMember = "SpecCheck";
            DataTable dataTable = db.GetTablePGVR();
            for (int j = 0; j < dataTable.Rows.Count; j++)
            { listpgvr.Add(new PGVR(dataTable.Rows[j].ItemArray[1].ToString(), dataTable.Rows[j].ItemArray[2].ToString())); }
            cbPGVR.DataSource = listpgvr;
          
            if (Tabel_client.Properties.Settings.Default.dtStartFix.Date == LocalDate.Date )
                {
                    btStart.Text = Tabel_client.Properties.Settings.Default.dtStartFix.ToString();
                btStart.Enabled = false;

                }

        }

        private void TbSpecAchiv_LostFocus(object sender, EventArgs e)
        {
            if (tbSpecAchiv.Text == "")
            { tbSpecAchiv.Text = "Достижения"; }
        }

        private void TbSpecAchiv_GotFocus(object sender, EventArgs e)
        {
            if (tbSpecAchiv.Text == "Достижения")
            { tbSpecAchiv.Text = ""; }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            IReadOnlyCollection<TimeZoneInfo> timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
            if (Tabel_client.Properties.Settings.Default.selectedTimeZone == "")
            {
                labelTime.Text = DateTime.Now.ToString();
            }
            else
            {
                TimeZoneInfo obj = timeZoneInfos.ElementAt(Convert.ToInt32(Tabel_client.Properties.Settings.Default.selectedTimeZone));
                DateTime dt = TimeZoneInfo.ConvertTime(DateTime.Now, obj);
                labelTime.Text = dt.ToString();
            }
        }

        private void Начало_MouseDown(object sender, MouseEventArgs e)
        {
            btStart.Text = "Для фиксации, удерживай 2 сек.";
            timerStartTime.Elapsed += Timer_Elapsed;
            timerStartTime.Interval = 2000;
            timerStartTime.AutoReset = false;
            timerStartTime.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                if (btStart.Text == "Для фиксации, удерживай 2 сек.")
                {
                    btStart.Text = DateTime.Now.ToString();
                    btStart.Enabled = false;

                    IReadOnlyCollection<TimeZoneInfo> timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
                    if (Tabel_client.Properties.Settings.Default.selectedTimeZone == "")
                    {
                        btStart.Text = DateTime.Now.ToString();
                        Tabel_client.Properties.Settings.Default.dtStartFix = DateTime.Now;
                        Tabel_client.Properties.Settings.Default.Save();
                        timerStartTime.Stop();
                    }
                    else
                    {
                        TimeZoneInfo obj = timeZoneInfos.ElementAt(Convert.ToInt32(Tabel_client.Properties.Settings.Default.selectedTimeZone));
                        DateTime dt = TimeZoneInfo.ConvertTime(DateTime.Now, obj);
                        btStart.Text = dt.ToString();
                        Tabel_client.Properties.Settings.Default.dtStartFix = dt;
                        Tabel_client.Properties.Settings.Default.Save();
                        timerStartTime.Stop();
                    }
                }
            }
            ));
        }
        

        private void Начало_MouseUp(object sender, MouseEventArgs e)
        {

            if (btStart.Text== "Для фиксации, удерживай 2 сек.")
            { btStart.Text = "Зафиксировать начало";
            }
            timerStartTime.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 = new Form3();
            Form3.Show();
        }

        private void TimerEndTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                if (btEnd.Text == "Для фиксации, удерживай 2 сек.")
                {
                    
                    IReadOnlyCollection<TimeZoneInfo> timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
                    if (Tabel_client.Properties.Settings.Default.selectedTimeZone == "")
                    {
                        btEnd.Text = DateTime.Now.ToString();
                        Tabel_client.Properties.Settings.Default.dtEndFix = DateTime.Now;
                       
                    }
                    else
                    {
                        TimeZoneInfo obj = timeZoneInfos.ElementAt(Convert.ToInt32(Tabel_client.Properties.Settings.Default.selectedTimeZone));
                        DateTime dt = TimeZoneInfo.ConvertTime(DateTime.Now, obj);
                        btEnd.Text = dt.ToString();
                        Tabel_client.Properties.Settings.Default.dtEndFix = dt;
                        
                    }
                    Tabel_client.Properties.Settings.Default.Save();
                    btEnd.Enabled = false;
                    cbCity.Enabled = false;
                    cbPGVR.Enabled = false;
                    cbSpecCheck.Enabled = false;
                    tbSpecAchiv.Enabled = false;
                    btAddPGVR.Enabled = false;

                    db.year = DateTime.Parse(btStart.Text).Year;
                    db.month = DateTime.Parse(btStart.Text).Month;
                    db.day = DateTime.Parse(btStart.Text).Day;
                    db.hStart = DateTime.Parse(btStart.Text).Hour;
                    db.minStart = DateTime.Parse(btStart.Text).Minute;
                    db.hEnd = DateTime.Parse(btEnd.Text).Hour;
                    db.minEnd = DateTime.Parse(btEnd.Text).Minute;
                    db.specCheck = cbSpecCheck.Text;
                    db.specAchiv = tbSpecAchiv.Text;
                    db.city = cbCity.Text;
                    db.AddAllRows();
                    timerEndTime.Stop();
                    this.Close();
                }
            }));
        }
        private void btEnd_MouseUp(object sender, MouseEventArgs e)
        {
            if (btEnd.Text == "Для фиксации, удерживай 2 сек." || btEnd.Text == "Сначала зафиксируй начало")
            {
                btEnd.Text = "Зафиксировать конец";            }
            
            timerEndTime.Stop();
                
        }

        private void btEnd_MouseDown(object sender, MouseEventArgs e)
        {
            if (btStart.Text == "Зафиксировать начало")
            { btEnd.Text = "Сначала зафиксируй начало"; }
            else
            {
                btEnd.Text = "Для фиксации, удерживай 2 сек.";
                timerEndTime.Elapsed += TimerEndTime_Elapsed; ;
                timerEndTime.Interval = 2000;
                timerEndTime.Start();
            }
        }

        private void btAddPGVR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbPGVR.CheckedItems.Count; i++)
                {
                if (tbSpecAchiv.Text== "Достижения")
                { tbSpecAchiv.Text = ""; }
                tbSpecAchiv.Text = tbSpecAchiv.Text + " " +cbPGVR.CheckedItems[i].ToString();
                    }
        }

        private void btEnd_Click(object sender, EventArgs e)
        {

        }


        #region Transparency

        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern bool DwmIsCompositionEnabled();

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);

        //    if (DwmIsCompositionEnabled())
        //    {
        //        Paint the glass effect.
        //        var margins = new MARGINS();
        //        margins.Top = 10000;
        //        margins.Left = 10000;
        //        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        //    }
        //}

        [StructLayout(LayoutKind.Sequential)]
        struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }

        #endregion

        #region Bottommost

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOACTIVATE = 0x0010;

        void ToBack()
        {
            SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ToBack();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            ToBack();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ToBack();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            ToBack();
        }

        #endregion

        #region Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return;
            }

            base.OnMouseMove(e);
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}