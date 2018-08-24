using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TaxesGovAzToExcel
{
    public partial class Main : Form
    {
        //*****************************************
        public static int DocType { get; set; }
        //*****************************************
        public static string TaxesIO { get; set; }
        //*****************************************
        private static string myTextForBegin;
        public static string TextForBegin
        {
            get { return myTextForBegin = "&nbsp;"; }
            set { myTextForBegin = value; }
        }
        //*****************************************
        public static int TaxesVeziyyet { get; set; }
        //*****************************************
        public static string EVHFsVOEN { get; set; }
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
                    TaxesIO = "I";
                }
                else if (comboBoxHereket.SelectedIndex == 1)
                {
                    TaxesIO = "O";
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

        private static DateTime SQLStrToDate(string str)
        {
            string xyear = "", xmonth = "", xday = "";
            xyear += str[0];
            xyear += str[1];
            xyear += str[2];
            xyear += str[3];
            xmonth += str[4];
            xmonth += str[5];
            xday += str[6];
            xday += str[7];
            DateTime date = new DateTime(int.Parse(xyear), int.Parse(xmonth), int.Parse(xday));
            return date;
        }

        private static string[] CreateLinkArray(string link, string beginDate, string endDate)
        {
            //EVHF    //https://vroom.e-taxes.gov.az/index/index/printServlet?tkn=OTAyMzEyNjI4OTA2OTQ1MTQ1LG51bGwsNCwxNTI4ODI5MjMyNTY2LDAwMTM4OTcx&w=2&v=&fd=20180612000000&td=20180612000000&s=&n=&sw=0&r=1&sv=1501069851
            //E-Qaimə //http://eqaime.e-taxes.gov.az/index/index/printServlet?tkn=OTAyMzEyNjI4OTA2OTQ1MTQ1LG51bGwsMywxNTI4ODI5MDQ3NzgzLDAwMTM4OTcx&w=2&v=&fd=20180612000000&td=20180612000000&s=&n=&sw=0&r=1&sv=1501069851

            DateTime beginDateTime = SQLStrToDate(beginDate);

            TimeSpan difference = SQLStrToDate(endDate).Date - beginDateTime.Date;
            int days = (int)difference.TotalDays + 1;
            Console.WriteLine($"{days} Days");

            string[] linkArray = new string[days];

            DateTime tempDateTime;

            string[] sayt = new string[] { "s://vroom", "://eqaime" };

            for (int i = 0; i < days; i++)
            {
                string strDate = "";
                tempDateTime = beginDateTime.AddDays(i);
                strDate = strDate + tempDateTime.Year.ToString();
                strDate += tempDateTime.Month.ToString().Length == 1 ? $"0{tempDateTime.Month.ToString()}" : $"{tempDateTime.Month.ToString()}";
                strDate += tempDateTime.Day.ToString().Length == 1 ? $"0{tempDateTime.Day.ToString()}" : $"{tempDateTime.Day.ToString()}";

                linkArray[i] = @"http" + sayt[DocType] + ".e-taxes.gov.az/index/index/" +
                    @"printServlet?tkn=" + CopyToken(link) +
                    @"&w=2" +
                    @"&v=" +
                    @"&fd=" + strDate + @"000000" +
                    @"&td=" + strDate + @"000000" +
                    @"&s=" +
                    @"&n=" +
                    @"&sw=" + (TaxesIO == "I" ? "0" : "1") +
                    @"&r=1" +
                    @"&sv=" + EVHFsVOEN;
            }

            int xleft = Console.CursorLeft, xtop = Console.CursorTop;
            for (int i = 0; i < linkArray.Length; i++)
            {
                try
                {
                    Console.SetCursorPosition(xleft, xtop);
                    Console.WriteLine($"{i + 1} link oxunur");
                    if (CheckLink(linkArray[i])) continue;
                    else throw new Exception("Линк не отвечает");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error link: {e}");
                }
            }

            return linkArray;
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

        public static bool CheckLink(string link)
        {
            //var htmlWeb = new HtmlWeb
            //{
            //    OverrideEncoding = Encoding.UTF8
            //};
            //var htmlDoc = new HtmlDocument();
            Stream stream = new MemoryStream();
            using (StreamWriter sw = new StreamWriter(stream))
            {
                sw.Write(link);
            }
            WebClient wc = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            string result;
            try
            {
                result = wc.DownloadString(link);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            if (result.Length > 0) return true;
            return false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string[] linrArray = CreateLinkArray(textBoxLink.Text,
                (Convert.ToString(dateTimePickerIlk.Value.Year) +
                Convert.ToString(dateTimePickerIlk.Value.Month) +
                Convert.ToString(dateTimePickerIlk.Value.Day)), 
                (Convert.ToString(dateTimePickerSon.Value.Year) +
                Convert.ToString(dateTimePickerSon.Value.Month) +
                Convert.ToString(dateTimePickerSon.Value.Day)));

            List<EVHF> EVHFlist = new List<EVHF>();
            List<EQaime> EQlist = new List<EQaime>();
            if (DocType == 0)
            {
                EVHF.RZLoadFromTaxes(ref EVHFlist, linrArray);
                EVHF.CreateExcel(ref EVHFlist);
            }
            else
            {
                EQaime.RZLoadFromTaxes(ref EQlist, linrArray);
                EQaime.CreateExcel(ref EQlist);
            }
        }

        private static string CopyToken(string link)
        {
            string XToken = "";
            for (int i = 0; i < link.Length; i++)
            {
                string Xtemp = "";
                if (i < link.Length - 3)
                {
                    Xtemp += link[i + 0];
                    Xtemp += link[i + 1];
                    if (Xtemp == "t=")
                    {
                        int x = 0, xlen = 0;
                        do
                        {
                            xlen = i + Xtemp.Length + x++;
                            if (link[xlen] == '&') break;
                            if (xlen <= link.Length - 1) XToken += link[xlen]; else break;
                        } while (true);
                    }
                }
            }
            if (XToken.Length == 0)
            {
                for (int i = 0; i < link.Length; i++)
                {
                    string Xtemp = "";
                    if (i < link.Length - 3)
                    {
                        Xtemp += link[i + 0];
                        Xtemp += link[i + 1];
                        Xtemp += link[i + 2];
                        Xtemp += link[i + 3];
                        if (Xtemp == "tkn=")
                        {
                            int x = 0, xlen = 0;
                            do
                            {
                                xlen = i + Xtemp.Length + x++;
                                if (link[xlen] == '&') break;
                                if (xlen <= link.Length - 1) XToken += link[xlen]; else break;
                            } while (true);
                        }
                    }
                }
            }
            return XToken;
        }
        private static string CopyVoen(string link)
        {
            string XVoen = "";
            for (int i = 0; i < link.Length; i++)
            {
                string Xtemp = "";
                if (i < link.Length - 3)
                {
                    Xtemp += link[i + 0];
                    Xtemp += link[i + 1];
                    if (Xtemp == "v=")
                    {
                        for (int t = link.Length - 10; t < link.Length; t++)
                        {
                            XVoen += link[t];
                        }
                        //int x = 0, xlen = 0;
                        //do
                        //{
                        //    xlen = i + Xtemp.Length + x++;
                        //    if (xlen >= link.Length) xlen = link.Length - 1;
                        //    if (link[xlen] == '=' || link[xlen] == '&') break;
                        //    if (xlen <= link.Length - 1) XVoen += link[xlen]; else break;
                        //} while (true);
                    }
                }
            }
            if (XVoen.Length == 0)
            {
                for (int i = 0; i < link.Length; i++)
                {
                    string Xtemp = "";
                    if (i < link.Length - 3)
                    {
                        Xtemp += link[i + 0];
                        Xtemp += link[i + 1];
                        Xtemp += link[i + 2];
                        Xtemp += link[i + 3];
                        if (Xtemp == "&sv=")
                        {
                            for (int t = link.Length - 10; t < link.Length; t++)
                            {
                                XVoen += link[t];
                            }
                            //int x = 0, xlen = 0;
                            //do
                            //{
                            //    xlen = i + Xtemp.Length + x++;
                            //    if (link[xlen] == '=' || link[xlen] == '&') break;
                            //    if (xlen <= link.Length - 1) XVoen += link[xlen]; else break;
                            //} while (true);
                        }
                    }
                }
            }
            return XVoen;
        }
        private static bool ChackDate(string str)
        {
            if (str.Length == 8)
            {
                string str_year = "";
                str_year += str[0];
                str_year += str[1];
                str_year += str[2];
                str_year += str[3];
                int year = int.Parse(str_year);
                if (year <= 2000 || year > (DateTime.Now).Year) return false;

                string str_month = "";
                str_month += str[4];
                str_month += str[5];
                int month = int.Parse(str_month);
                if (month < 1 || month > 12) return false;

                string str_day = "";
                str_day += str[6];
                str_day += str[7];
                int day = int.Parse(str_day);
                if (day < 1 || day > DateTime.DaysInMonth(year, month)) return false;
            }
            else return false;
            return true;
        }

        private void textBoxLink_Leave(object sender, EventArgs e)
        {
            bool tokenExsist = false;
            if (CopyToken(textBoxLink.Text).Length > 0) tokenExsist = true;

            if (tokenExsist == true)
            {
                if (textBoxLink.Text.IndexOf("vroom") > -1)
                {
                    if (DocType != 0)
                    {
                        MessageBox.Show("Link sehv daxil edilib!");
                        return;
                    }
                }
                else if (textBoxLink.Text.IndexOf("eqaime") > -1)
                {
                    if (DocType != 1)
                    {
                        MessageBox.Show("Link sehv daxil edilib!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Link sehv daxil edilib!");
                    return;
                }
            }

            dateTimePickerIlk.Value = dateTimePickerIlk.Value.AddDays(- 1);

            labelIlkTarix.Visible = true;
            labelSonTarix.Visible = true;
            dateTimePickerIlk.Visible = true;
            dateTimePickerSon.Visible = true;

            buttonStart.Visible = true;
        }

        private void comboBoxDocType_Changed(object sender, EventArgs e)
        {
            if (comboBoxDocType.Items.Count > 0 && comboBoxDocType.SelectedIndex >= 0)
            {
                labelLink.Visible = true;
                textBoxLink.Visible = true;
            }
        }
    }
}
