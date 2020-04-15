namespace Tabel
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dtMonthHoli = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addHoli = new System.Windows.Forms.Button();
            this.DelHoli = new System.Windows.Forms.Button();
            this.btUpload = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // dtMonthHoli
            // 
            this.dtMonthHoli.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtMonthHoli.CustomFormat = "HH:mm";
            this.dtMonthHoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtMonthHoli.Location = new System.Drawing.Point(611, 39);
            this.dtMonthHoli.Name = "dtMonthHoli";
            this.dtMonthHoli.ShowUpDown = true;
            this.dtMonthHoli.Size = new System.Drawing.Size(279, 27);
            this.dtMonthHoli.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Заполнение произвоственного календаря на год.";
            // 
            // addHoli
            // 
            this.addHoli.Location = new System.Drawing.Point(611, 72);
            this.addHoli.Name = "addHoli";
            this.addHoli.Size = new System.Drawing.Size(118, 23);
            this.addHoli.TabIndex = 76;
            this.addHoli.Text = "Выходной";
            this.addHoli.UseVisualStyleBackColor = true;
            this.addHoli.Click += new System.EventHandler(this.addHoli_Click);
            // 
            // DelHoli
            // 
            this.DelHoli.Location = new System.Drawing.Point(766, 72);
            this.DelHoli.Name = "DelHoli";
            this.DelHoli.Size = new System.Drawing.Size(124, 23);
            this.DelHoli.TabIndex = 77;
            this.DelHoli.Text = "Рабочий";
            this.DelHoli.UseVisualStyleBackColor = true;
            this.DelHoli.Click += new System.EventHandler(this.DelHoli_Click);
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(1028, 51);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(160, 33);
            this.btUpload.TabIndex = 80;
            this.btUpload.Text = "Выгрузить";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btDownload
            // 
            this.btDownload.Location = new System.Drawing.Point(1028, 12);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(160, 33);
            this.btDownload.TabIndex = 81;
            this.btDownload.Text = "Загрузить";
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 656);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.DelHoli);
            this.Controls.Add(this.addHoli);
            this.Controls.Add(this.dtMonthHoli);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Производственный календарь";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtMonthHoli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addHoli;
        private System.Windows.Forms.Button DelHoli;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}