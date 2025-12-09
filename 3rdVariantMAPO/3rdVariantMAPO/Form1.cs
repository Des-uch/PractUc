using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
