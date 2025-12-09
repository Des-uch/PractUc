using System;
using System.Windows.Forms;

namespace _3rdVariantMAPO
{
    public partial class initialform : Form
    {
        public initialform()
        {
            InitializeComponent();
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
