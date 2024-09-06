using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class RegisterForm : Form
    {
        DataBase dataBase = new DataBase();

        public RegisterForm()
        {
            InitializeComponent();
            registorLoginField.Text = "Введите имя";
            registorLoginField.ForeColor = Color.Gray;
            registorPasswordField.Text = "Введите пароль";
            registorPasswordField.ForeColor = Color.Gray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(47, 107, 224);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void enterRegistorButton_Click(object sender, EventArgs e)
        {
            if (registorLoginField.Text == "Введите имя")
                MessageBox.Show("Введите имя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (registorPasswordField.Text == "")
                MessageBox.Show("Введите пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (registorPasswordField.Text != examinationRegistorPasswordField.Text)
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (doesTheUserExist())
                return;

            DataBase dataBase = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @password)", dataBase.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = registorLoginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = registorPasswordField.Text;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!");
                Form1 form1 = new Form1();
                Hide();
                form1.ShowDialog();
            }
            else
                MessageBox.Show("Аккаунт не был создан!");

            dataBase.CloseConnection();
        }

        private void passwordEye_Click(object sender, EventArgs e)
        {
            if (registorPasswordField.UseSystemPasswordChar)
            {
                registorPasswordField.UseSystemPasswordChar = false;
                passwordEye.Image = Properties.Resources.path_to_open_eye_image;
            }
            else
            {
                registorPasswordField.UseSystemPasswordChar = true;
                passwordEye.Image = Properties.Resources.path_to_closed_eye_imagе;
            }
        }

        private void registorLoginField_Enter(object sender, EventArgs e)
        {
            if (registorLoginField.Text == "Введите имя")
            {
                registorLoginField.Text = "";
                registorLoginField.ForeColor = Color.Black;
            }
        }

        private void registorLoginField_Leave(object sender, EventArgs e)
        {
            if (registorLoginField.Text == "")
            {
                registorLoginField.Text = "Введите имя";
                registorLoginField.ForeColor = Color.Gray;
            }
        }

        private void registorPasswordField_Enter(object sender, EventArgs e)
        {
            if (registorPasswordField.Text == "Введите пароль")
            {
                registorPasswordField.Text = "";
                registorPasswordField.ForeColor = Color.Black;
                registorPasswordField.UseSystemPasswordChar = true;
            }
        }

        private void registorPasswordField_Leave(object sender, EventArgs e)
        {
            if (registorPasswordField.Text == "")
            {
                registorPasswordField.UseSystemPasswordChar = false;
                registorPasswordField.Text = "Введите пароль";
                registorPasswordField.ForeColor = Color.Gray;
            }
        }

        public bool doesTheUserExist()
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Lu", dataBase.GetConnection());
            command.Parameters.Add("@Lu", MySqlDbType.VarChar).Value = registorLoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка регистрации, введите уникальный логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
