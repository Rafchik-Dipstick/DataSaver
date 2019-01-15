namespace DotNetTraining.View
{
    partial class AddProfile
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
            this.btn_Add_Add = new System.Windows.Forms.Button();
            this.consttxtpass = new System.Windows.Forms.Label();
            this.consttxtLogin = new System.Windows.Forms.Label();
            this.consttxtProfileName = new System.Windows.Forms.Label();
            this.txt_Add_Pass = new System.Windows.Forms.TextBox();
            this.txt_add_Login = new System.Windows.Forms.TextBox();
            this.txt_add_Name = new System.Windows.Forms.TextBox();
            this.btn_Add_Srv = new System.Windows.Forms.Button();
            this.consttxtServices = new System.Windows.Forms.Label();
            this.cbxServices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Add_Add
            // 
            this.btn_Add_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add_Add.Location = new System.Drawing.Point(28, 104);
            this.btn_Add_Add.Name = "btn_Add_Add";
            this.btn_Add_Add.Size = new System.Drawing.Size(330, 39);
            this.btn_Add_Add.TabIndex = 19;
            this.btn_Add_Add.Text = "Add Profile";
            this.btn_Add_Add.UseVisualStyleBackColor = true;
            this.btn_Add_Add.Click += new System.EventHandler(this.btn_Add_Add_Click);
            // 
            // consttxtpass
            // 
            this.consttxtpass.AutoSize = true;
            this.consttxtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consttxtpass.Location = new System.Drawing.Point(38, 78);
            this.consttxtpass.Name = "consttxtpass";
            this.consttxtpass.Size = new System.Drawing.Size(78, 20);
            this.consttxtpass.TabIndex = 18;
            this.consttxtpass.Text = "Password";
            this.consttxtpass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // consttxtLogin
            // 
            this.consttxtLogin.AutoSize = true;
            this.consttxtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consttxtLogin.Location = new System.Drawing.Point(70, 48);
            this.consttxtLogin.Name = "consttxtLogin";
            this.consttxtLogin.Size = new System.Drawing.Size(48, 20);
            this.consttxtLogin.TabIndex = 17;
            this.consttxtLogin.Text = "Login";
            // 
            // consttxtProfileName
            // 
            this.consttxtProfileName.AutoSize = true;
            this.consttxtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consttxtProfileName.Location = new System.Drawing.Point(9, 24);
            this.consttxtProfileName.Name = "consttxtProfileName";
            this.consttxtProfileName.Size = new System.Drawing.Size(99, 20);
            this.consttxtProfileName.TabIndex = 16;
            this.consttxtProfileName.Text = "Profile Name";
            // 
            // txt_Add_Pass
            // 
            this.txt_Add_Pass.Location = new System.Drawing.Point(131, 78);
            this.txt_Add_Pass.Name = "txt_Add_Pass";
            this.txt_Add_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Add_Pass.TabIndex = 15;
            // 
            // txt_add_Login
            // 
            this.txt_add_Login.Location = new System.Drawing.Point(131, 52);
            this.txt_add_Login.Name = "txt_add_Login";
            this.txt_add_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_add_Login.TabIndex = 14;
            // 
            // txt_add_Name
            // 
            this.txt_add_Name.Location = new System.Drawing.Point(131, 26);
            this.txt_add_Name.Name = "txt_add_Name";
            this.txt_add_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_add_Name.TabIndex = 13;
            // 
            // btn_Add_Srv
            // 
            this.btn_Add_Srv.Location = new System.Drawing.Point(237, 70);
            this.btn_Add_Srv.Name = "btn_Add_Srv";
            this.btn_Add_Srv.Size = new System.Drawing.Size(121, 28);
            this.btn_Add_Srv.TabIndex = 12;
            this.btn_Add_Srv.Text = "Add Service";
            this.btn_Add_Srv.UseVisualStyleBackColor = true;
            this.btn_Add_Srv.Click += new System.EventHandler(this.btn_Add_Srv_Click);
            // 
            // consttxtServices
            // 
            this.consttxtServices.AutoSize = true;
            this.consttxtServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consttxtServices.Location = new System.Drawing.Point(246, 9);
            this.consttxtServices.Name = "consttxtServices";
            this.consttxtServices.Size = new System.Drawing.Size(95, 25);
            this.consttxtServices.TabIndex = 11;
            this.consttxtServices.Text = "Services";
            // 
            // cbxServices
            // 
            this.cbxServices.FormattingEnabled = true;
            this.cbxServices.Location = new System.Drawing.Point(237, 43);
            this.cbxServices.Name = "cbxServices";
            this.cbxServices.Size = new System.Drawing.Size(121, 21);
            this.cbxServices.TabIndex = 10;
            // 
            // AddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 150);
            this.Controls.Add(this.btn_Add_Add);
            this.Controls.Add(this.consttxtpass);
            this.Controls.Add(this.consttxtLogin);
            this.Controls.Add(this.consttxtProfileName);
            this.Controls.Add(this.txt_Add_Pass);
            this.Controls.Add(this.txt_add_Login);
            this.Controls.Add(this.txt_add_Name);
            this.Controls.Add(this.btn_Add_Srv);
            this.Controls.Add(this.consttxtServices);
            this.Controls.Add(this.cbxServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProfile";
            this.Load += new System.EventHandler(this.AddProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Add;
        private System.Windows.Forms.Label consttxtpass;
        private System.Windows.Forms.Label consttxtLogin;
        private System.Windows.Forms.Label consttxtProfileName;
        private System.Windows.Forms.TextBox txt_Add_Pass;
        private System.Windows.Forms.TextBox txt_add_Login;
        private System.Windows.Forms.TextBox txt_add_Name;
        private System.Windows.Forms.Button btn_Add_Srv;
        private System.Windows.Forms.Label consttxtServices;
        private System.Windows.Forms.ComboBox cbxServices;
    }
}