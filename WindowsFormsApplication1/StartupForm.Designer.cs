namespace Tabel_client
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.виджетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяВерсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Menu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Учет табельного времени";
            this.notifyIcon1.Visible = true;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.виджетToolStripMenuItem,
            this.полнаяВерсияToolStripMenuItem,
            this.CMExit});
            this.Menu.Name = "Exit";
            this.Menu.Size = new System.Drawing.Size(211, 104);
            // 
            // виджетToolStripMenuItem
            // 
            this.виджетToolStripMenuItem.Name = "виджетToolStripMenuItem";
            this.виджетToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.виджетToolStripMenuItem.Text = "Быстрый ввод";
            this.виджетToolStripMenuItem.ToolTipText = "Быстрый ввод табеля, только для текущего дня, при условии заполнения всех предыду" +
    "щих дней месяца.";
            this.виджетToolStripMenuItem.Click += new System.EventHandler(this.виджетToolStripMenuItem_Click);
            // 
            // полнаяВерсияToolStripMenuItem
            // 
            this.полнаяВерсияToolStripMenuItem.Name = "полнаяВерсияToolStripMenuItem";
            this.полнаяВерсияToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.полнаяВерсияToolStripMenuItem.Text = "Полная версия";
            this.полнаяВерсияToolStripMenuItem.ToolTipText = "Полная версия ";
            this.полнаяВерсияToolStripMenuItem.Click += new System.EventHandler(this.полнаяВерсияToolStripMenuItem_Click);
            // 
            // CMExit
            // 
            this.CMExit.Name = "CMExit";
            this.CMExit.Size = new System.Drawing.Size(210, 24);
            this.CMExit.Text = "Выход";
            this.CMExit.ToolTipText = "Выход из программы.";
            this.CMExit.Click += new System.EventHandler(this.CMExit_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 79);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "StartupForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Shown += new System.EventHandler(this.StartupForm_Shown);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem CMExit;
        private System.Windows.Forms.ToolStripMenuItem виджетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полнаяВерсияToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}