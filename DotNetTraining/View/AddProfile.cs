using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DotNetTraining.View
{
    public partial class AddProfile : Form
    {
        public AddProfile()
        {
            InitializeComponent();

        }

        SQLiteConnection connection = new SQLiteConnection("Data_Source = Stuff.db; Version = 3");

        private void btn_Add_Srv_Click(object sender, EventArgs e)
        {
            var dialog = new Controller.DefaultPass();
            dialog.CreateWindow("Enter Service", 3);
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = Controller.SqlManager.InsertService;
            command.Parameters.Add("@serviceName", System.Data.DbType.String).Value = dialog.temp.ToUpper();
            command.ExecuteNonQuery();
            connection.Close();
            Controller.ChangeLog.AddServices(dialog.temp);
            this.Close();

        }

        private void btn_Add_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.CorrectData.StrIsNotNull(txt_add_Login.Text, txt_add_Name.Text, txt_Add_Pass.Text)
                    && Controller.CorrectData.StrHasNoSpacebars(txt_add_Login.Text, txt_add_Name.Text, txt_Add_Pass.Text)
                    && Controller.CorrectData.CbxSelectedItem(cbxServices))
                {
                    var password = new Model.Password();

                    var dialog = new Controller.DefaultPass();
                    dialog.CreateWindow("Enter Password", 0);

                    password.SetPassword(dialog.temp);
                    dialog.temp = null;

                    if (password.IsRight())
                    {
                        connection.Open();
                        SQLiteCommand command = connection.CreateCommand();
                        command.CommandText = Controller.SqlManager.InsertProfile;
                        command.Parameters.Add("@profileName", DbType.String).Value = txt_add_Login.Text.ToUpper();
                        command.Parameters.Add("@login", DbType.String).Value = txt_add_Name.Text.ToUpper();
                        command.Parameters.Add("@password", DbType.String).Value = Model.Crypt.Encrypt(txt_Add_Pass.Text, password.GetPassword());
                        password.NullPass();
                        command.Parameters.Add("@service", DbType.String).Value = cbxServices.Text.ToUpper();
                        command.ExecuteNonQuery();
                        connection.Close();

                        Controller.ChangeLog.AddProfile(txt_add_Login.Text.ToUpper(), txt_add_Name.Text.ToUpper());
                        this.Close();
                    }
                    else { MessageBox.Show("Check password"); }
                }
                else { MessageBox.Show("Check Data"); }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }

        }

        private void AddProfile_Load(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = Controller.SqlManager.UpdateServices;
            SQLiteDataReader read = command.ExecuteReader();
            {
                while (read.Read())
                {
                    cbxServices.Items.Add(read["ServiceName"]);
                }
            }
            connection.Close();
        }
    }
}

