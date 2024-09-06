using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class LoginForm : Form
    {

        DataBase dataBase = new DataBase();
        public LoginForm()
        {
            InitializeComponent();

            passwordField.AutoSize = false;
            passwordField.Size = new Size(passwordField.Width, 49);
            StartPosition = FormStartPosition.CenterScreen;
            userField.MaxLength = 50;
            passwordField.MaxLength = 50;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(47, 107, 224);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void passwordEye_Click(object sender, EventArgs e)
        {
            if (passwordField.UseSystemPasswordChar == true)
            {
                passwordField.UseSystemPasswordChar = false;
                passwordEye.Image = Properties.Resources.path_to_open_eye_image;
            }
            else
            {
                passwordField.UseSystemPasswordChar = true;
                passwordEye.Image = Properties.Resources.path_to_closed_eye_imagе;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string loginUser = userField.Text;
            string passwordUser = passwordField.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Lu AND `password` = @Pu", dataBase.GetConnection());
            command.Parameters.Add("@Lu", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@Pu", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Form1 form1 = new Form1();
                Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
