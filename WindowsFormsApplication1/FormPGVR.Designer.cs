namespace WindowsFormsApplication1
{
    partial class FormPGVR
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btDell = new System.Windows.Forms.Button();
            this.tbDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPGVRsumm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPGVR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(-1, 111);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(188, 35);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDell
            // 
            this.btDell.Location = new System.Drawing.Point(193, 111);
            this.btDell.Name = "btDell";
            this.btDell.Size = new System.Drawing.Size(169, 35);
            this.btDell.TabIndex = 1;
            this.btDell.Text = "Удалить";
            this.btDell.UseVisualStyleBackColor = true;
            this.btDell.Click += new System.EventHandler(this.btDell_Click_1);
            // 
            // tbDescr
            // 
            this.tbDescr.Location = new System.Drawing.Point(257, 81);
            this.tbDescr.Name = "tbDescr";
            this.tbDescr.Size = new System.Drawing.Size(421, 22);
            this.tbDescr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ПГВР:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание:";
            // 
            // cbPGVRsumm
            // 
            this.cbPGVRsumm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPGVRsumm.FormattingEnabled = true;
            this.cbPGVRsumm.Location = new System.Drawing.Point(-1, 13);
            this.cbPGVRsumm.Name = "cbPGVRsumm";
            this.cbPGVRsumm.Size = new System.Drawing.Size(684, 24);
            this.cbPGVRsumm.TabIndex = 6;
            this.cbPGVRsumm.SelectedIndexChanged += new System.EventHandler(this.cbPGVRsumm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Редактирование:";
            // 
            // tbPGVR
            // 
            this.tbPGVR.Location = new System.Drawing.Point(-1, 81);
            this.tbPGVR.Name = "tbPGVR";
            this.tbPGVR.Size = new System.Drawing.Size(252, 22);
            this.tbPGVR.TabIndex = 8;
            // 
            // FormPGVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 147);
            this.Controls.Add(this.tbPGVR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPGVRsumm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescr);
            this.Controls.Add(this.btDell);
            this.Controls.Add(this.btAdd);
            this.Name = "FormPGVR";
            this.Text = "FormPGVR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPGVR_FormClosed);
            this.Load += new System.EventHandler(this.FormPGVR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDell;
        private System.Windows.Forms.TextBox tbDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPGVRsumm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPGVR;
    }
}