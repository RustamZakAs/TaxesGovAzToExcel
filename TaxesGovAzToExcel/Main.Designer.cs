namespace TaxesGovAzToExcel
{
    partial class Main
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
            this.labelNov = new System.Windows.Forms.Label();
            this.comboBoxNov = new System.Windows.Forms.ComboBox();
            this.comboBoxHereket = new System.Windows.Forms.ComboBox();
            this.labelHereket = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNov
            // 
            this.labelNov.AutoSize = true;
            this.labelNov.Location = new System.Drawing.Point(12, 9);
            this.labelNov.Name = "labelNov";
            this.labelNov.Size = new System.Drawing.Size(117, 13);
            this.labelNov.TabIndex = 0;
            this.labelNov.Text = "Məlumat növünü seçin:";
            // 
            // comboBoxNov
            // 
            this.comboBoxNov.FormattingEnabled = true;
            this.comboBoxNov.Location = new System.Drawing.Point(15, 25);
            this.comboBoxNov.Name = "comboBoxNov";
            this.comboBoxNov.Size = new System.Drawing.Size(345, 21);
            this.comboBoxNov.TabIndex = 1;
            this.comboBoxNov.SelectedIndexChanged += new System.EventHandler(this.comboBoxNov_Leave);
            this.comboBoxNov.Leave += new System.EventHandler(this.comboBoxNov_Leave);
            // 
            // comboBoxHereket
            // 
            this.comboBoxHereket.FormattingEnabled = true;
            this.comboBoxHereket.Location = new System.Drawing.Point(15, 72);
            this.comboBoxHereket.Name = "comboBoxHereket";
            this.comboBoxHereket.Size = new System.Drawing.Size(345, 21);
            this.comboBoxHereket.TabIndex = 2;
            // 
            // labelHereket
            // 
            this.labelHereket.AutoSize = true;
            this.labelHereket.Location = new System.Drawing.Point(12, 56);
            this.labelHereket.Name = "labelHereket";
            this.labelHereket.Size = new System.Drawing.Size(115, 13);
            this.labelHereket.TabIndex = 3;
            this.labelHereket.Text = "Hərəkət növünü seçin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaxesGovAzToExcel.Properties.Resources.question_mark_PNG48;
            this.pictureBox1.Location = new System.Drawing.Point(558, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHereket);
            this.Controls.Add(this.comboBoxHereket);
            this.Controls.Add(this.comboBoxNov);
            this.Controls.Add(this.labelNov);
            this.Name = "Main";
            this.Text = "AR İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNov;
        private System.Windows.Forms.ComboBox comboBoxNov;
        private System.Windows.Forms.ComboBox comboBoxHereket;
        private System.Windows.Forms.Label labelHereket;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

