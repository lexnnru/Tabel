namespace Tabel
{
    partial class FormCity
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
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(3, 12);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(359, 24);
            this.cbCity.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 79);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCity";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Радактор списка городов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCity_FormClosed);
            this.Load += new System.EventHandler(this.FormCity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}