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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            if (Controller.ReadWrite.read() == "")
            {
                MessageBox.Show("Welcome. Enter Password!");
                var dialog = new Controller.DefaultPass();
                dialog.CreateWindow("Enter Password", 1);
            }
        }

        public Form form = new Form();
        ComboBox comboBox1 = new ComboBox();
        TextBox textbox1 = new TextBox();
        ListBox listBox = new ListBox();

        private void btn_m_AddProf_Click(object sender, EventArgs e)
        {
            var dialog = new AddProfile();
            dialog.ShowDialog();
        }

        private void btn_m_CheckProf_Click(object sender, EventArgs e)
        {

            Model.Password password = new Model.Password();
            var dialog = new Controller.DefaultPass();
            dialog.CreateWindow("Enter Password", 0);
            if (dialog.DialogResult == DialogResult.OK)
            {
                password.SetPassword(dialog.temp);

                if (dialog.DialogResult == DialogResult.OK && password.IsRight())
                {

                    form.FormBorderStyle = FormBorderStyle.Fixed3D;
                    form.Text = "Info";
                    form.Size = new Size(281, 147);
                    form.StartPosition = FormStartPosition.CenterScreen;

                    Label label1 = new Label();
                    label1.Size = new Size(118, 15);
                    label1.Location = new Point(21, 9);
                    label1.Text = "Find by ProfileName";

                    Label label2 = new Label();
                    label2.Size = new Size(89, 15);
                    label2.Location = new Point(145, 9);
                    label2.Text = "Find by Service";

                    Button btn1 = new Button();
                    btn1.Size = new Size(115, 36);
                    btn1.Location = new Point(24, 56);
                    btn1.Text = "Find";

                    Button btn2 = new Button();
                    btn2.Size = new Size(100, 36);
                    btn2.Location = new Point(145, 56);
                    btn2.Text = "Find";

                    textbox1.Location = new Point(24, 29);
                    textbox1.Size = new Size(115, 20);


                    comboBox1.Location = new Point(145, 29);
                    comboBox1.Size = new Size(100, 21);

                    form.Controls.Add(comboBox1);
                    form.Controls.Add(textbox1);
                    form.Controls.Add(btn1);
                    form.Controls.Add(btn2);
                    form.Controls.Add(label1);
                    form.Controls.Add(label2);




                    btn1.Click += new System.EventHandler(btn1_Click);
                    btn2.Click += new System.EventHandler(btn2_Click);

                    using (SQLiteConnection connection = new SQLiteConnection("Data_Source=Stuff.db; Version=3"))
                    {
                        comboBox1.Items.Clear();
                        SQLiteCommand command = connection.CreateCommand();
                        connection.Open();
                        command.CommandText = "SELECT ServiceName FROM Services ";
                        SQLiteDataReader read = command.ExecuteReader();
                        {

                            while (read.Read())
                            {
                                comboBox1.Items.Add(read["ServiceName"]);
                            }
                        }
                    }
                }
                form.ShowDialog();
            }

        }

        void btn1_Click(object sender, EventArgs e)
        {
            Model.Password password = new Model.Password();


            var dialog = new Controller.DefaultPass();
            dialog.CreateWindow("EnterPass", 0);
            if (dialog.DialogResult == DialogResult.OK)
            {
                password.SetPassword(dialog.temp);

                using (SQLiteConnection connection = new SQLiteConnection("Data_Source=Stuff.db; Version=3"))
                {
                    connection.Open();
                    SQLiteCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM DataBase WHERE ProfileName LIKE '%' || @profileName || '%'";
                    command.Parameters.Add("@profileName", System.Data.DbType.String).Value = textbox1.Text.ToUpper();
                    SQLiteDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string message = read["Password"].ToString();
                            MessageBox.Show((Model.Crypt.Decrypt(message, password.GetPassword())));
                        }

                    }
                    else
                    {
                        MessageBox.Show("No info");
                    }
                }
            }
        }

        void btn2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                Model.Password password = new Model.Password();


                var dialog = new Controller.DefaultPass();
                dialog.CreateWindow("EnterPass", 0);

                if (dialog.DialogResult == DialogResult.OK)
                {
                    password.SetPassword(dialog.temp);
                    if (password.IsRight())
                    {
                        using (SQLiteConnection connection = new SQLiteConnection("Data_Source=Stuff.db; Version=3"))
                        {
                            connection.Open();
                            SQLiteCommand command = connection.CreateCommand();
                            command.CommandText = "SELECT * FROM DataBase  WHERE Service LIKE '%' || @Service || '%'";
                            command.Parameters.Add("@Service", System.Data.DbType.String).Value = comboBox1.Text.ToUpper();
                            SQLiteDataReader read = command.ExecuteReader();
                            if (read.HasRows)
                            {
                                Model.Transporter transporter;
                                List<Model.Transporter> list = new List<Model.Transporter>();
                                while (read.Read())
                                {
                                    transporter = new Model.Transporter();
                                    Model.Transporter.AddTransporterData
                                        (read["ProfileName"].ToString(), read["Login"].ToString(),
                                        (Model.Crypt.Decrypt(read["Password"].ToString(), password.GetPassword())), transporter); // Transporter - Object for structured trasfer data 
                                                                                                                                  // Form-Form.
                                    list.Add(transporter);
                                }
                                password.NullPass();

                                Form form = new Form();
                                if (list.Any())
                                {
                                    form.Size = new Size(328, 262);
                                    listBox.Items.Clear();
                                    listBox.Size = new Size(287, 173);
                                    listBox.Location = new Point(12, 40);
                                    form.Controls.Add(listBox);
                                    foreach (Model.Transporter temp in list)
                                    {
                                        listBox.Items.Add(temp.ToString());
                                    }
                                    form.FormBorderStyle = FormBorderStyle.Fixed3D;
                                    form.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("There is no users there");
                                }
                            }
                        }

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void btn_m_DelProf_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection connection = new SQLiteConnection("Data_Source=Stuff.db; Version=3"))
            {

                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE  FROM DataBase ";
                command.ExecuteNonQuery();
                connection.Close();
                Controller.ChangeLog.DeleteProfile();
            }
        }

        private void btn_m_DelServ_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data_Source=Stuff.db; Version=3"))
            {

                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE  FROM Services ";
                command.ExecuteNonQuery();
                connection.Close();
                Controller.ChangeLog.DeletedServices();
            }
        }
    }
}


