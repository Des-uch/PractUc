using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3rdVariantMAPO
{
    public partial class Form1 : Form
    {
        string passwd = "Password";
        string login = "login";
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwd == textBox2.Text)
            {
                if (login == textBox1.Text)
                {
                    this.Hide();
                    Table NewForm = new Table();
                    NewForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный ввод");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ввод");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите логин...")
                textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Введите логин...";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите пароль...")
                textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Введите пароль...";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Введите пароль...";
            textBox2.ForeColor = Color.Gray;
            textBox1.Text = "Введите логин...";
            textBox1.ForeColor = Color.Gray;
        }
    }
}
