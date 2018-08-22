using System;
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
        public Main()
        {
            InitializeComponent();
            //Text = "Azərbaycan Respublikasının İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";
            Text = "AR İnternet Vergi İdarəsinin elektron saytından məlumatların alınması";

            /*0*/comboBoxNov.Items.Add("Elektron Vergi Hesab Faktralar üzrə məlumatın alınması");
            /*1*/comboBoxNov.Items.Add("Elektro Qaimələr üzrə məlumatın alınması");
            /*2*/comboBoxNov.Items.Add("Əvəzləşmə ayı üzrə məlumatın alınması");
            /*3*/comboBoxNov.Items.Add("Depozit hesabından hərəkətin çıxarışı");

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
    }
}
