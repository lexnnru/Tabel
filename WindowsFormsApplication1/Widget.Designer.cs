namespace Tabel_client
{
    partial class Widget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.labelTime = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.cbSpecCheck = new System.Windows.Forms.ComboBox();
            this.btEnd = new System.Windows.Forms.Button();
            this.tbSpecAchiv = new System.Windows.Forms.RichTextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPGVR = new System.Windows.Forms.CheckedListBox();
            this.btAddPGVR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(75, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 17);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Дата";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(-1, 28);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(136, 65);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Зафиксировать начало";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Начало_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Начало_MouseUp);
            // 
            // cbSpecCheck
            // 
            this.cbSpecCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecCheck.FormattingEnabled = true;
            this.cbSpecCheck.Location = new System.Drawing.Point(89, 97);
            this.cbSpecCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSpecCheck.Name = "cbSpecCheck";
            this.cbSpecCheck.Size = new System.Drawing.Size(191, 24);
            this.cbSpecCheck.TabIndex = 4;
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(141, 28);
            this.btEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(139, 65);
            this.btEnd.TabIndex = 8;
            this.btEnd.Text = "Зафиксировать конец";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btEnd_MouseDown);
            this.btEnd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btEnd_MouseUp);
            // 
            // tbSpecAchiv
            // 
            this.tbSpecAchiv.Location = new System.Drawing.Point(-1, 199);
            this.tbSpecAchiv.Name = "tbSpecAchiv";
            this.tbSpecAchiv.Size = new System.Drawing.Size(281, 68);
            this.tbSpecAchiv.TabIndex = 11;
            this.tbSpecAchiv.Text = "Достижения";
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(89, 126);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(191, 24);
            this.cbCity.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Спец. отм.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Город";
            // 
            // cbPGVR
            // 
            this.cbPGVR.FormattingEnabled = true;
            this.cbPGVR.Location = new System.Drawing.Point(9, 155);
            this.cbPGVR.Name = "cbPGVR";
            this.cbPGVR.Size = new System.Drawing.Size(228, 55);
            this.cbPGVR.TabIndex = 18;
            // 
            // btAddPGVR
            // 
            this.btAddPGVR.Location = new System.Drawing.Point(243, 156);
            this.btAddPGVR.Name = "btAddPGVR";
            this.btAddPGVR.Size = new System.Drawing.Size(37, 38);
            this.btAddPGVR.TabIndex = 19;
            this.btAddPGVR.Text = "=>";
            this.btAddPGVR.UseVisualStyleBackColor = true;
            this.btAddPGVR.Click += new System.EventHandler(this.btAddPGVR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAddPGVR);
            this.Controls.Add(this.cbPGVR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.tbSpecAchiv);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.cbSpecCheck);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Widget";
            this.ShowInTaskbar = false;
            this.Text = "Widget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ComboBox cbSpecCheck;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.RichTextBox tbSpecAchiv;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cbPGVR;
        private System.Windows.Forms.Button btAddPGVR;
        private System.Windows.Forms.Button button1;
    }
}