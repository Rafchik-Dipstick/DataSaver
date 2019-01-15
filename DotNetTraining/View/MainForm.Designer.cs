namespace DotNetTraining.View
{
    partial class MainForm
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
            this.btn_m_DelServ = new System.Windows.Forms.Button();
            this.btn_m_DelProf = new System.Windows.Forms.Button();
            this.btn_m_AddProf = new System.Windows.Forms.Button();
            this.btn_m_CheckProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_m_DelServ
            // 
            this.btn_m_DelServ.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_m_DelServ.Location = new System.Drawing.Point(120, 61);
            this.btn_m_DelServ.Name = "btn_m_DelServ";
            this.btn_m_DelServ.Size = new System.Drawing.Size(102, 42);
            this.btn_m_DelServ.TabIndex = 8;
            this.btn_m_DelServ.Text = "Delete Services";
            this.btn_m_DelServ.UseVisualStyleBackColor = true;
            this.btn_m_DelServ.Click += new System.EventHandler(this.btn_m_DelServ_Click);
            // 
            // btn_m_DelProf
            // 
            this.btn_m_DelProf.Location = new System.Drawing.Point(12, 60);
            this.btn_m_DelProf.Name = "btn_m_DelProf";
            this.btn_m_DelProf.Size = new System.Drawing.Size(102, 42);
            this.btn_m_DelProf.TabIndex = 7;
            this.btn_m_DelProf.Text = "Delete Profiles";
            this.btn_m_DelProf.UseVisualStyleBackColor = true;
            this.btn_m_DelProf.Click += new System.EventHandler(this.btn_m_DelProf_Click);
            // 
            // btn_m_AddProf
            // 
            this.btn_m_AddProf.Location = new System.Drawing.Point(12, 12);
            this.btn_m_AddProf.Name = "btn_m_AddProf";
            this.btn_m_AddProf.Size = new System.Drawing.Size(102, 42);
            this.btn_m_AddProf.TabIndex = 6;
            this.btn_m_AddProf.Text = "Add Profiles";
            this.btn_m_AddProf.UseVisualStyleBackColor = true;
            this.btn_m_AddProf.Click += new System.EventHandler(this.btn_m_AddProf_Click);
            // 
            // btn_m_CheckProf
            // 
            this.btn_m_CheckProf.Location = new System.Drawing.Point(120, 12);
            this.btn_m_CheckProf.Name = "btn_m_CheckProf";
            this.btn_m_CheckProf.Size = new System.Drawing.Size(102, 42);
            this.btn_m_CheckProf.TabIndex = 5;
            this.btn_m_CheckProf.Text = "Check Profiles";
            this.btn_m_CheckProf.UseVisualStyleBackColor = true;
            this.btn_m_CheckProf.Click += new System.EventHandler(this.btn_m_CheckProf_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 115);
            this.Controls.Add(this.btn_m_DelServ);
            this.Controls.Add(this.btn_m_DelProf);
            this.Controls.Add(this.btn_m_AddProf);
            this.Controls.Add(this.btn_m_CheckProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_m_DelServ;
        private System.Windows.Forms.Button btn_m_DelProf;
        private System.Windows.Forms.Button btn_m_AddProf;
        private System.Windows.Forms.Button btn_m_CheckProf;
    }
}