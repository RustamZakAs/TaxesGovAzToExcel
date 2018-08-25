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
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.dateTimePickerIlk = new System.Windows.Forms.DateTimePicker();
            this.labelIlkTarix = new System.Windows.Forms.Label();
            this.labelSonTarix = new System.Windows.Forms.Label();
            this.dateTimePickerSon = new System.Windows.Forms.DateTimePicker();
            this.panelParam = new System.Windows.Forms.Panel();
            this.labelVoen = new System.Windows.Forms.Label();
            this.textBoxVoen = new System.Windows.Forms.TextBox();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxReport = new System.Windows.Forms.PictureBox();
            this.pictureBoxParam = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownGun = new System.Windows.Forms.NumericUpDown();
            this.labelGun = new System.Windows.Forms.Label();
            this.panelParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGun)).BeginInit();
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
            this.comboBoxNov.Enter += new System.EventHandler(this.comboBoxNov_Leave);
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
            this.comboBoxHereket.SelectedIndexChanged += new System.EventHandler(this.comboBoxHereket_Changed);
            this.comboBoxHereket.Leave += new System.EventHandler(this.comboBoxHereket_Changed);
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
            this.comboBoxDocType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxDocType.Location = new System.Drawing.Point(9, 105);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(345, 21);
            this.comboBoxDocType.TabIndex = 3;
            this.comboBoxDocType.Visible = false;
            this.comboBoxDocType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDocType_Changed);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(6, 129);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(115, 13);
            this.labelLink.TabIndex = 7;
            this.labelLink.Text = "Saytın linkini daxil edin:";
            this.labelLink.Visible = false;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(9, 145);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(345, 20);
            this.textBoxLink.TabIndex = 4;
            this.textBoxLink.Visible = false;
            this.textBoxLink.Leave += new System.EventHandler(this.textBoxLink_Leave);
            // 
            // dateTimePickerIlk
            // 
            this.dateTimePickerIlk.Location = new System.Drawing.Point(9, 184);
            this.dateTimePickerIlk.Name = "dateTimePickerIlk";
            this.dateTimePickerIlk.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerIlk.TabIndex = 5;
            this.dateTimePickerIlk.Visible = false;
            // 
            // labelIlkTarix
            // 
            this.labelIlkTarix.AutoSize = true;
            this.labelIlkTarix.Location = new System.Drawing.Point(6, 168);
            this.labelIlkTarix.Name = "labelIlkTarix";
            this.labelIlkTarix.Size = new System.Drawing.Size(51, 13);
            this.labelIlkTarix.TabIndex = 10;
            this.labelIlkTarix.Text = "İlkin tarix:";
            this.labelIlkTarix.Visible = false;
            // 
            // labelSonTarix
            // 
            this.labelSonTarix.AutoSize = true;
            this.labelSonTarix.Location = new System.Drawing.Point(186, 168);
            this.labelSonTarix.Name = "labelSonTarix";
            this.labelSonTarix.Size = new System.Drawing.Size(51, 13);
            this.labelSonTarix.TabIndex = 11;
            this.labelSonTarix.Text = "Son tarix:";
            this.labelSonTarix.Visible = false;
            // 
            // dateTimePickerSon
            // 
            this.dateTimePickerSon.Location = new System.Drawing.Point(189, 184);
            this.dateTimePickerSon.Name = "dateTimePickerSon";
            this.dateTimePickerSon.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerSon.TabIndex = 6;
            this.dateTimePickerSon.Visible = false;
            // 
            // panelParam
            // 
            this.panelParam.BackColor = System.Drawing.SystemColors.Control;
            this.panelParam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelParam.Controls.Add(this.labelGun);
            this.panelParam.Controls.Add(this.numericUpDownGun);
            this.panelParam.Controls.Add(this.labelVoen);
            this.panelParam.Controls.Add(this.textBoxVoen);
            this.panelParam.Location = new System.Drawing.Point(285, 6);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(218, 227);
            this.panelParam.TabIndex = 8;
            this.panelParam.Visible = false;
            // 
            // labelVoen
            // 
            this.labelVoen.AutoSize = true;
            this.labelVoen.Location = new System.Drawing.Point(6, 7);
            this.labelVoen.Name = "labelVoen";
            this.labelVoen.Size = new System.Drawing.Size(35, 13);
            this.labelVoen.TabIndex = 1;
            this.labelVoen.Text = "Vöen:";
            // 
            // textBoxVoen
            // 
            this.textBoxVoen.Location = new System.Drawing.Point(60, 4);
            this.textBoxVoen.Name = "textBoxVoen";
            this.textBoxVoen.Size = new System.Drawing.Size(151, 20);
            this.textBoxVoen.TabIndex = 9;
            this.textBoxVoen.Text = "1501069851";
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Location = new System.Drawing.Point(363, 6);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(218, 227);
            this.richTextBoxQuestion.TabIndex = 21;
            this.richTextBoxQuestion.Text = "";
            this.richTextBoxQuestion.TextChanged += new System.EventHandler(this.richTextBoxQuestion_TextChanged);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TaxesGovAzToExcel.Properties.Resources.VN_logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(363, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(218, 227);
            this.pictureBoxLogo.TabIndex = 20;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxReport
            // 
            this.pictureBoxReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxReport.Image = global::TaxesGovAzToExcel.Properties.Resources.report;
            this.pictureBoxReport.Location = new System.Drawing.Point(485, 233);
            this.pictureBoxReport.Name = "pictureBoxReport";
            this.pictureBoxReport.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReport.TabIndex = 18;
            this.pictureBoxReport.TabStop = false;
            this.pictureBoxReport.Click += new System.EventHandler(this.pictureBoxQuestion_Click);
            // 
            // pictureBoxParam
            // 
            this.pictureBoxParam.Image = global::TaxesGovAzToExcel.Properties.Resources.param;
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
            this.pictureBoxQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxQuestion.Image = global::TaxesGovAzToExcel.Properties.Resources.question;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(553, 233);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuestion.TabIndex = 4;
            this.pictureBoxQuestion.TabStop = false;
            this.pictureBoxQuestion.Click += new System.EventHandler(this.pictureBoxQuestion_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Image = global::TaxesGovAzToExcel.Properties.Resources.Ms_Office_Excel_logo;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(8, 218);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStart.Size = new System.Drawing.Size(86, 38);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Yüklə";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.UseCompatibleTextRendering = true;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownGun
            // 
            this.numericUpDownGun.Location = new System.Drawing.Point(60, 30);
            this.numericUpDownGun.Name = "numericUpDownGun";
            this.numericUpDownGun.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownGun.TabIndex = 10;
            this.numericUpDownGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGun
            // 
            this.labelGun.AutoSize = true;
            this.labelGun.Location = new System.Drawing.Point(6, 32);
            this.labelGun.Name = "labelGun";
            this.labelGun.Size = new System.Drawing.Size(53, 13);
            this.labelGun.TabIndex = 11;
            this.labelGun.Text = "Gün fərgi:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 265);
            this.Controls.Add(this.panelParam);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.pictureBoxReport);
            this.Controls.Add(this.pictureBoxParam);
            this.Controls.Add(this.pictureBoxQuestion);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dateTimePickerSon);
            this.Controls.Add(this.labelSonTarix);
            this.Controls.Add(this.labelIlkTarix);
            this.Controls.Add(this.dateTimePickerIlk);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.labelDocType);
            this.Controls.Add(this.labelHereket);
            this.Controls.Add(this.comboBoxHereket);
            this.Controls.Add(this.comboBoxNov);
            this.Controls.Add(this.labelNov);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Main";
            this.Text = "AR İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";
            this.Click += new System.EventHandler(this.Main_Click);
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGun)).EndInit();
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
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.DateTimePicker dateTimePickerIlk;
        private System.Windows.Forms.Label labelIlkTarix;
        private System.Windows.Forms.Label labelSonTarix;
        private System.Windows.Forms.DateTimePicker dateTimePickerSon;
        private System.Windows.Forms.PictureBox pictureBoxParam;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.TextBox textBoxVoen;
        private System.Windows.Forms.Label labelVoen;
        private System.Windows.Forms.PictureBox pictureBoxReport;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelGun;
        private System.Windows.Forms.NumericUpDown numericUpDownGun;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
    }
}

