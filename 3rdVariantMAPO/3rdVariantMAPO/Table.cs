using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace _3rdVariantMAPO
{
    public partial class Table : Form
    {
        private string exeDir;
        private string dbPath;
        private string myconn;
        private OleDbConnection conn;
       
        public Table()
        {
            InitializeComponent();
            exeDir = AppDomain.CurrentDomain.BaseDirectory;
            dbPath = Path.Combine(exeDir, "ExBD.mdb");
            myconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;
            conn = new OleDbConnection(myconn);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            load();
        }

        private void buttonOBN_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addrow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delrow();
        }

        private void load()
        {
            string sel = "SELECT * FROM Продукты";
            try
            {
                conn.Open();
                OleDbCommand select = new OleDbCommand(sel, conn);
                OleDbDataReader reader = select.ExecuteReader();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                    dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Addrow()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            try
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string insertQuery = "INSERT INTO Продукты ([Название], [Категория], [Бренд], [Единица], [Цена]) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", row.Cells["Название"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("?", row.Cells["Категория"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("?", row.Cells["Бренд"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("?", row.Cells["Единица"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("?", row.Cells["Цена"].Value ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные добавлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            load();
        }
        private void Delrow()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            try
            {
                conn.Open();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string deleteQuery = "DELETE FROM Продукты WHERE [Код] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", row.Cells["Код"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Данные удалены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            load();
        }

    }
}
