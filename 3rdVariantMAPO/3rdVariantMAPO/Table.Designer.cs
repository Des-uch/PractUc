namespace _3rdVariantMAPO
{
    partial class Table
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
            this.buttonOBN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonINS = new System.Windows.Forms.Button();
            this.buttoDEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOBN
            // 
            this.buttonOBN.BackColor = System.Drawing.Color.DarkRed;
            this.buttonOBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOBN.Location = new System.Drawing.Point(12, 12);
            this.buttonOBN.Name = "buttonOBN";
            this.buttonOBN.Size = new System.Drawing.Size(95, 60);
            this.buttonOBN.TabIndex = 1;
            this.buttonOBN.Text = "Загрузить таблицу заново";
            this.buttonOBN.UseVisualStyleBackColor = false;
            this.buttonOBN.Click += new System.EventHandler(this.buttonOBN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 384);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть приложение";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonINS
            // 
            this.buttonINS.BackColor = System.Drawing.Color.DarkRed;
            this.buttonINS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonINS.Location = new System.Drawing.Point(12, 78);
            this.buttonINS.Name = "buttonINS";
            this.buttonINS.Size = new System.Drawing.Size(95, 60);
            this.buttonINS.TabIndex = 4;
            this.buttonINS.Text = "Добавить выбранную строку в таблицу";
            this.buttonINS.UseVisualStyleBackColor = false;
            this.buttonINS.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttoDEL
            // 
            this.buttoDEL.BackColor = System.Drawing.Color.DarkRed;
            this.buttoDEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttoDEL.Location = new System.Drawing.Point(13, 144);
            this.buttoDEL.Name = "buttoDEL";
            this.buttoDEL.Size = new System.Drawing.Size(95, 60);
            this.buttoDEL.TabIndex = 5;
            this.buttoDEL.Text = "Удалить строку";
            this.buttoDEL.UseVisualStyleBackColor = false;
            this.buttoDEL.Click += new System.EventHandler(this.button3_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(770, 408);
            this.Controls.Add(this.buttoDEL);
            this.Controls.Add(this.buttonINS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOBN);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOBN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonINS;
        private System.Windows.Forms.Button buttoDEL;
    }
}