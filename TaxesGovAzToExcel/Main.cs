using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TaxesGovAzToExcel
{
    public partial class Main : Form
    {
        //*****************************************
        public static int DocType { get; set; }
        //*****************************************
        private static string myTextForBegin;
        public static string TextForBegin
        {
            get { return myTextForBegin = "&nbsp;"; }
            set { myTextForBegin = value; }
        }
        //*****************************************
        public static string TaxesIO { get; set; }
        //*****************************************
        public static int TaxesVeziyyet { get; set; }
        //*****************************************
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
            } else
            {
                labelDocType.Visible = false;
                comboBoxDocType.Visible = false;
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
            pictureBoxLogo.Visible = true;
        }

        private void comboBoxHereket_Changed(object sender, EventArgs e)
        {
            labelDocType.Visible = true;
            comboBoxDocType.Visible = true;
            if (comboBoxNov.SelectedIndex == 0 || comboBoxNov.SelectedIndex == 1)
            {
                if (comboBoxHereket.SelectedIndex == 0)
                {
                    DocType = 'I';
                }
                else if (comboBoxHereket.SelectedIndex == 1)
                {
                    DocType = 'O';
                }
                comboBoxDocType.Text = "";
                comboBoxDocType.Items.Clear();
                if (comboBoxNov.SelectedIndex == 0)
                {
                    /*0*/comboBoxDocType.Items.Add("Hamısı");
                    /*1*/comboBoxDocType.Items.Add("Normal");
                    /*2*/comboBoxDocType.Items.Add("Ləğv olunmuşlar");
                    /*3*/comboBoxDocType.Items.Add("Dəqiqləşmiş");
                }
                else if (comboBoxNov.SelectedIndex == 1)
                {
                    /*0*/ comboBoxDocType.Items.Add("Hamısı");
                    /*1*/ comboBoxDocType.Items.Add("Dəqiqləşmiş");
                    /*2*/ comboBoxDocType.Items.Add("Ləğv edilib (Qaimə ləğv edilib)");
                    /*3*/ comboBoxDocType.Items.Add("(Təsdiq gözləyən)");
                    /*4*/ comboBoxDocType.Items.Add("Normal(Təsdiqlənmiş)");
                    /*5*/ comboBoxDocType.Items.Add("EVHF hazırlanıb (Faktura hazırlanıb)");
                    /*6*/ comboBoxDocType.Items.Add("Rədd olunub (Rədd olunub)");
                    /*7*/ comboBoxDocType.Items.Add("EVHF göndərilib (Faktura göndərilib)");
                    /*8*/ comboBoxDocType.Items.Add("EVHF ləğv olunub (Faktura ləğv olunub)");
                    /*9*/ comboBoxDocType.Items.Add("(Sistem tərəfindən təsdiqlənmiş)");
                    /*10*/comboBoxDocType.Items.Add("Sistem EVHF hazırlayıb (Sistem fakturanı hazırlayıb)");
                    /*11*/comboBoxDocType.Items.Add("Sistem qaiməni ləğv edib (Sistem qaiməni ləğv edib)");
                }
            }
            if (comboBoxDocType.Items.Count > 0) comboBoxDocType.SelectedIndex = 0;
        }

        private void LinkCheck(object sender, EventArgs e)
        {

        }

        public static void CreateDir(string path)
        {
            // Specify the directory you want to manipulate.
            //path = @"C:\EVHF files";
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
    }
}
