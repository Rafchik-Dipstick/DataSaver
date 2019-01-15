using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTraining.Controller
{
     class DefaultPass

    {
       
        public DialogResult DialogResult { get; set; }
         Form dialog = new Form();
         Label lbl = new Label();
         Button btn = new Button();
         TextBox txtBox = new TextBox();
         public string temp { set; get; }
         public int flag;

        public void CreateWindow(string _temp,int flagOpeartion)
        {
            dialog.FormBorderStyle = FormBorderStyle.Fixed3D;
            flag = flagOpeartion;
            dialog.Size = new Size(250, 120);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.StartPosition = FormStartPosition.CenterScreen;

            
            lbl.Text = _temp;
            lbl.Location = new System.Drawing.Point(20, 10);

           
            btn.Location = new System.Drawing.Point(40, 35);
            btn.Size = new System.Drawing.Size(160, 35);
            btn.Text = "Enter";

            
            txtBox.Location = new System.Drawing.Point(110, 10);
            if (flag == 1 || flag == 2)
            {
                txtBox.PasswordChar = '*';
            }
            dialog.Controls.Add(txtBox);
            dialog.Controls.Add(lbl);
            dialog.Controls.Add(btn);

            btn.Click += new System.EventHandler(Pressed);
            
            dialog.ShowDialog();
           

        }

         void Pressed(object sender,EventArgs e)
        {
            if(txtBox.Text != "" && !txtBox.Text.Contains(" "))
            {
                string s = Model.Crypt.CreateMD5(txtBox.Text);
                
                if (flag == 1)
                {
                    ReadWrite.Write(Model.Crypt.CreateMD5(txtBox.Text));
                    temp = Model.Crypt.CreateMD5(txtBox.Text);
                    DialogResult = DialogResult.OK;
                    dialog.Close();
                }
                if (flag == 0)
                {
                    temp = txtBox.Text;
                    if (ReadWrite.read().Trim() == s)
                    {
                       DialogResult = DialogResult.OK;
                        dialog.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong pass");
                    }
                }
                if(flag == 3)
                {
                    temp = txtBox.Text;
                    DialogResult = DialogResult.OK;
                    dialog.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Weak Password or SpaceBars included");
            }
            
        }
    }
}
