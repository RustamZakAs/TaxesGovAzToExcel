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
            this.labelDocType = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxParam = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelParam = new System.Windows.Forms.Panel();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNov
            // 
            this.labelNov.AutoSize = true;
            this.labelNov.Location = new System.Drawing.Point(6, 9);
            this.labelNov.Name = "labelNov";
            this.labelNov.Size = new System.Drawing.Size(117, 13);
            this.labelNov.TabIndex = 0;
            this.labelNov.Text = "Məlumat növünü seçin:";
            // 
            // comboBoxNov
            // 
            this.comboBoxNov.FormattingEnabled = true;
            this.comboBoxNov.Location = new System.Drawing.Point(9, 25);
            this.comboBoxNov.Name = "comboBoxNov";
            this.comboBoxNov.Size = new System.Drawing.Size(345, 21);
            this.comboBoxNov.TabIndex = 1;
            this.comboBoxNov.SelectedIndexChanged += new System.EventHandler(this.comboBoxNov_Leave);
            this.comboBoxNov.Leave += new System.EventHandler(this.comboBoxNov_Leave);
            // 
            // comboBoxHereket
            // 
            this.comboBoxHereket.FormattingEnabled = true;
            this.comboBoxHereket.Location = new System.Drawing.Point(9, 65);
            this.comboBoxHereket.Name = "comboBoxHereket";
            this.comboBoxHereket.Size = new System.Drawing.Size(345, 21);
            this.comboBoxHereket.TabIndex = 2;
            this.comboBoxHereket.Visible = false;
            // 
            // labelHereket
            // 
            this.labelHereket.AutoSize = true;
            this.labelHereket.Location = new System.Drawing.Point(6, 49);
            this.labelHereket.Name = "labelHereket";
            this.labelHereket.Size = new System.Drawing.Size(115, 13);
            this.labelHereket.TabIndex = 3;
            this.labelHereket.Text = "Hərəkət növünü seçin:";
            this.labelHereket.Visible = false;
            // 
            // labelDocType
            // 
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(6, 89);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(108, 13);
            this.labelDocType.TabIndex = 5;
            this.labelDocType.Text = "Sənəd növünü seçin:";
            this.labelDocType.Visible = false;
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(9, 105);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(345, 21);
            this.comboBoxDocType.TabIndex = 6;
            this.comboBoxDocType.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saytın linkini daxil edin:";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            this.textBox1.Enter += new System.EventHandler(this.LinkCheck);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "İlkin tarix:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Son tarix:";
            this.label4.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(189, 184);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Visible = false;
            // 
            // pictureBoxParam
            // 
            this.pictureBoxParam.Image = global::TaxesGovAzToExcel.Properties.Resources.img_41580;
            this.pictureBoxParam.Location = new System.Drawing.Point(519, 233);
            this.pictureBoxParam.Name = "pictureBoxParam";
            this.pictureBoxParam.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxParam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxParam.TabIndex = 15;
            this.pictureBoxParam.TabStop = false;
            this.pictureBoxParam.Click += new System.EventHandler(this.pictureBoxParam_Click);
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.Image = global::TaxesGovAzToExcel.Properties.Resources.question_mark_PNG48;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(553, 233);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuestion.TabIndex = 4;
            this.pictureBoxQuestion.TabStop = false;
            this.pictureBoxQuestion.Click += new System.EventHandler(this.pictureBoxQuestion_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TaxesGovAzToExcel.Properties.Resources.images;
            this.pictureBoxLogo.Location = new System.Drawing.Point(363, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(218, 227);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Image = global::TaxesGovAzToExcel.Properties.Resources.Iconstoc_Ms_Office_2013_Excel;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(8, 218);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(79, 40);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Yüklə";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            // 
            // panelParam
            // 
            this.panelParam.Location = new System.Drawing.Point(363, 6);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(218, 227);
            this.panelParam.TabIndex = 16;
            this.panelParam.Visible = false;
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Location = new System.Drawing.Point(363, 6);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(218, 227);
            this.richTextBoxQuestion.TabIndex = 17;
            this.richTextBoxQuestion.Text = "";
            this.richTextBoxQuestion.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 265);
            this.Controls.Add(this.pictureBoxParam);
            this.Controls.Add(this.pictureBoxQuestion);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.panelParam);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.labelDocType);
            this.Controls.Add(this.labelHereket);
            this.Controls.Add(this.comboBoxHereket);
            this.Controls.Add(this.comboBoxNov);
            this.Controls.Add(this.labelNov);
            this.Name = "Main";
            this.Text = "AR İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";
            this.Click += new System.EventHandler(this.Main_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNov;
        private System.Windows.Forms.ComboBox comboBoxNov;
        private System.Windows.Forms.ComboBox comboBoxHereket;
        private System.Windows.Forms.Label labelHereket;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.Label labelDocType;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxParam;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
    }
}

