﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaxesGovAzToExcel
{
    public partial class Main : Form
    {
        private static string myTextForBegin;
        public static string TextForBegin
        {
            get { return myTextForBegin = "&nbsp;"; }
            set { myTextForBegin = value; }
        }

        public Main()
        {
            InitializeComponent();
            //Text = "Azərbaycan Respublikasının İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";
            Text = "AR İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";

            /*0*/comboBoxNov.Items.Add("Elektron Vergi Hesab Faktralar üzrə məlumatın alınması");
            /*1*/comboBoxNov.Items.Add("Elektro Qaimələr üzrə məlumatın alınması");
            /*2*/comboBoxNov.Items.Add("Əvəzləşmə ayı üzrə məlumatın alınması");
            /*3*/comboBoxNov.Items.Add("Depozit hesabından hərəkətin çıxarışı");

            textBoxVoen.Text = "1501069851";

            if (comboBoxNov.Items.Count > 0) comboBoxNov.SelectedIndex = 0;
        }

        private void comboBoxNov_Leave(object sender, EventArgs e)
        {
            labelHereket.Visible = true;
            comboBoxHereket.Visible = true;
            comboBoxHereket.Items.Clear();
            if (comboBoxNov.SelectedIndex == 0 || comboBoxNov.SelectedIndex == 1)
            {
                comboBoxHereket.Items.Add("Gələnlər");
                comboBoxHereket.Items.Add("Göndərdiklərim");
            }
            comboBoxHereket.Text = "";
            if (comboBoxHereket.Items.Count > 0) comboBoxHereket.SelectedIndex = 0;
        }

        private void pictureBoxQuestion_Click(object sender, EventArgs e)
        {
            if (pictureBoxLogo.Visible == true) pictureBoxLogo.Visible = false;
            if (panelParam.Visible == true) panelParam.Visible = false;
            if (richTextBoxQuestion.Visible == false) richTextBoxQuestion.Visible = true;
            else
            {
                richTextBoxQuestion.Visible = false;
                pictureBoxLogo.Visible = true;
            }
        }

        private void pictureBoxParam_Click(object sender, EventArgs e)
        {
            if (pictureBoxLogo.Visible == true) pictureBoxLogo.Visible = false;
            if (richTextBoxQuestion.Visible == true) richTextBoxQuestion.Visible = false;
            if (panelParam.Visible == false) panelParam.Visible = true;
            else
            {
                panelParam.Visible = false;
                pictureBoxLogo.Visible = true;
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            if (panelParam.Visible == true) panelParam.Visible = false;
            if (richTextBoxQuestion.Visible == true) richTextBoxQuestion.Visible = false;
        }

        private void LinkCheck(object sender, EventArgs e)
        {

        }
    }
}
