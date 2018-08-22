using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaxesGovAzToExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxNov.Items.Add("Elektron Vergi Hesab Faktralar üzrə məlumatın alınması");
            comboBoxNov.Items.Add("Elektro Qaimələr üzrə məlumatın alınması");
            comboBoxNov.Items.Add("Əvəzləşmə ayı üzrə məlumatın alınması");
            comboBoxNov.Items.Add("Depozit hesabından hərəkətin çıxarışı");
            


        }
    }
}
