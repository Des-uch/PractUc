namespace _3rdVariantMAPO
{
    partial class initialform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initialform));
            this.buttonENTER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonENTER
            // 
            this.buttonENTER.BackColor = System.Drawing.Color.DarkRed;
            this.buttonENTER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonENTER.Location = new System.Drawing.Point(132, 215);
            this.buttonENTER.Name = "buttonENTER";
            this.buttonENTER.Size = new System.Drawing.Size(182, 34);
            this.buttonENTER.TabIndex = 0;
            this.buttonENTER.Text = "Войти";
            this.buttonENTER.UseVisualStyleBackColor = false;
            this.buttonENTER.Click += new System.EventHandler(this.buttonENTER_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 197);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // initialform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(447, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonENTER);
            this.Name = "initialform";
            this.Text = "initialform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonENTER;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}