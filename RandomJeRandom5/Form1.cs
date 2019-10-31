using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomJeRandom_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1. deklarace
        #region deklarace
        int num1, num2, num3, num4, num5, num6, max1,max2,max3, max4, max;
        string data;//I use this in saveDialoge
        #endregion

        //Export
        #region Export

        //.txt
        private void MenuConvertTOtxt_Click(object sender, EventArgs e)
        {
            #region txt
            if (svFl.ShowDialog() == DialogResult.OK)
            {
                StreamWriter soubor = new StreamWriter(svFl.FileName + ".txt", false, Encoding.Default);

                for (int i = 1; i <= 6; i++)
                {
                    switch (i)
                    {
                        case 1:
                            soubor.WriteLine("1: - " + num1);
                            break;
                        case 2:
                            soubor.WriteLine("2: - " + num2);
                            break;
                        case 3:
                            soubor.WriteLine("3: - " + num3);
                            break;
                        case 4:
                            soubor.WriteLine("4: - " + num4);
                            break;
                        case 5:
                            soubor.WriteLine("5: - " + num5);
                            break;
                        case 6:
                            soubor.WriteLine("6: - " + num6);
                            break;
                    }
                }
                soubor.Close();
            }
            #endregion
        }

        //.doc
        private void MenuConvertTOdoc_Click(object sender, EventArgs e)
        {

            #region doc
            if (svFl.ShowDialog() == DialogResult.OK)
            {
                StreamWriter soubor = new StreamWriter(svFl.FileName + ".doc", false, Encoding.Default);

                for (int i = 1; i <= 6; i++)
                {
                    switch (i)
                    {
                        case 1:
                            soubor.WriteLine("1: - " + num1);
                            break;
                        case 2:
                            soubor.WriteLine("2: - " + num2);
                            break;
                        case 3:
                            soubor.WriteLine("3: - " + num3);
                            break;
                        case 4:
                            soubor.WriteLine("4: - " + num4);
                            break;
                        case 5:
                            soubor.WriteLine("5: - " + num5);
                            break;
                        case 6:
                            soubor.WriteLine("6: - " + num6);
                            break;
                    }
                }
                soubor.Close();
            }
            #endregion

        }

        //.xlsx
        private void DoexclsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region .csv
            
            if(svFl.ShowDialog()==DialogResult.OK)
            {
                StreamWriter soubor = new StreamWriter(svFl.FileName+".csv", false, Encoding.Default);

                for(int i=1; i<=6;i++)
                {
                    switch(i)
                    {
                        case 1:
                            soubor.WriteLine("1: - "+num1);
                            break;
                        case 2:
                            soubor.WriteLine("2: - " + num2);
                            break;
                        case 3:
                            soubor.WriteLine("3: - " + num3);
                            break;
                        case 4:
                            soubor.WriteLine("4: - " + num4);
                            break;
                        case 5:
                            soubor.WriteLine("5: - " + num5);
                            break;
                        case 6:
                            soubor.WriteLine("6: - " + num6);
                            break;
                    }
                }
                soubor.Close();
            }

            #endregion

        }
        #endregion

        //8. menu
        #region menu

        private void NovinkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poslední aktualizace - 23.10.2019"+Environment.NewLine+"1. Fix bugů" + Environment.NewLine + "2. Přidání složky *O programu* a *Novinky*" + Environment.NewLine + "3. Jsou přidaná nová funkce! Od teď se dá uložit data do .csv/.doc/.txt Nachází se v *Menu>Uložit* ");
        }

        private void PomocToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Klikej na NumPadu 1-6 :D");
        }


        private void InformaceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Program napsal Mykyta Vorobiov, žák SPŠ, SOŠ a SOU, Hradec Králové roku 2019 pro www.tahacky.cz");
        }
        #endregion

        private void NováStatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //7. statistika
            #region Nova statistika
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            num5 = 0;
            num6 = 0;

            lblNum1.Text = "1 - " + num1.ToString();
            lblNum2.Text = "2 - " + num2.ToString();
            lblNum3.Text = "3 - " + num3.ToString();
            lblNum4.Text = "4 - " + num4.ToString();
            lblNum5.Text = "5 - " + num5.ToString();
            lblNum6.Text = "6 - " + num6.ToString();

            graf1.Value = 0;
            graf2.Value = 0;
            graf3.Value = 0;
            graf4.Value = 0;
            graf5.Value = 0;
            graf6.Value = 0;

            lblNum1.ForeColor = Color.Black;
            lblNum2.ForeColor = Color.Black;
            lblNum3.ForeColor = Color.Black;
            lblNum4.ForeColor = Color.Black;
            lblNum5.ForeColor = Color.Black;
            lblNum6.ForeColor = Color.Black;

            lblMax.Text = "";
            #endregion
        }

        //2.
        #region 2. Load
        private void Form1_Load(object sender, EventArgs e)
        {

            //2. inicializace
            #region inicializace
            this.Width = 800;
            this.Height = 500;

            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            num5 = 0;
            num6 = 0;
            #endregion

            //grafika
            #region
            panel4.BackColor = Color.FromArgb(20, Color.Pink);
            #endregion
        }
        #endregion


        //3. numpad
        #region Udalosti po zmacknuti numpadu
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //4. switch
            #region switch
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    num1++;
                    lblNum1.Text = "1 - " + num1.ToString();
                    #region Graf
                    graf1.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf2.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf3.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf4.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf5.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf6.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    #endregion
                    graf1.Value = num1;
                    break;

                case Keys.NumPad2:
                    num2++;
                    lblNum2.Text = "2 - " + num2.ToString();
                    #region Graf
                    graf1.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf2.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf3.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf4.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf5.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf6.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    #endregion
                    graf2.Value = num2;
                    break;

                case Keys.NumPad3:
                    num3++;
                    lblNum3.Text = "3 - " + num3.ToString();
                    #region Graf
                    graf1.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf2.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf3.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf4.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf5.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf6.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    #endregion
                    graf3.Value = num3;
                    break;

                case Keys.NumPad4:
                    num4++;
                    lblNum4.Text = "4 - " + num4.ToString();
                    #region Graf
                    graf1.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf2.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf3.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf4.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf5.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf6.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    #endregion
                    graf4.Value = num4;
                    break;

                case Keys.NumPad5:

                    num5++;
                    lblNum5.Text = "5 - " + num5.ToString();
                    #region Graf
                    graf1.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf2.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf3.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf4.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf5.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf6.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    #endregion
                    graf5.Value = num5;
                    break;

                case Keys.NumPad6:
                    num6++;
                    lblNum6.Text = "6 - " + num6.ToString();
                    #region Graf
                    graf1.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf2.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf3.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf4.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf5.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    graf6.Maximum = num1 + num2 + num3 + num4 + num5 + num6;
                    #endregion
                    graf6.Value = num6;
                    break;
            }
            #endregion

            //5. lblNums
            #region Maximum Numbers
            max1 = Math.Max(num1,num2);
            max2 = Math.Max(num3, num4);
            max3 = Math.Max(num5, num6);
            max4 = Math.Max(max1, max2);
            max = Math.Max(max3, max4);

            if (num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5 || num1 == num6 || num2 == num3 || num2 == num4 || num2 == num5 || num2 == num6 || num3 == num4 || num3 == num5 || num3 == num6 || num4 == num5 || num4 == num6 || num5 == num6)
            {
                lblNum6.ForeColor = Color.Black;
                lblNum5.ForeColor = Color.Black;
                lblNum4.ForeColor = Color.Black;
                lblNum3.ForeColor = Color.Black;
                lblNum2.ForeColor = Color.Black;
                lblNum1.ForeColor = Color.Black;
                lblNum1.ForeColor = Color.Black;

                lblMax.Text = "Víc je: ";
                if(num1==max)
                {
                    lblMax.Text += "1 ";
                    lblNum1.ForeColor = Color.Green;
                }

                if (num2 == max)
                {
                    lblMax.Text += "2 ";
                    lblNum2.ForeColor = Color.Green;
                }

                if (num3 == max)
                {
                    lblMax.Text += "3 ";
                    lblNum3.ForeColor = Color.Green;
                }

                if (num4 == max)
                {
                    lblMax.Text += "4 ";
                    lblNum4.ForeColor = Color.Green;
                }

                if (num5 == max)
                {
                    lblMax.Text += "5 ";
                    lblNum5.ForeColor = Color.Green;
                }

                if (num6 == max)
                {
                    lblMax.Text += "6 ";
                    lblNum6.ForeColor = Color.Green;
                }
            }


            else
            { 
                if (max == num1)
                {
                    lblMax.Text = "Víc je: 1";
                    lblNum6.ForeColor = Color.Black;
                    lblNum5.ForeColor = Color.Black;
                    lblNum4.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Green;
                }
                else if (max == num2)
                {
                    lblMax.Text = "Víc je: 2";
                    lblNum6.ForeColor = Color.Black;
                    lblNum5.ForeColor = Color.Black;
                    lblNum4.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Green;
                }
                else if (max == num3)
                {
                    lblMax.Text = "Víc je: 3";
                    lblNum6.ForeColor = Color.Black;
                    lblNum5.ForeColor = Color.Black;
                    lblNum4.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Green;
                }
                else if (max == num4)
                {
                    lblMax.Text = "Víc je: 4";
                    lblNum4.ForeColor = Color.Green;
                    lblNum6.ForeColor = Color.Black;
                    lblNum5.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Black;
                }
                else if (max == num5)
                {
                    lblMax.Text = "Víc je: 5";
                    lblNum5.ForeColor = Color.Green;
                    lblNum6.ForeColor = Color.Black;
                    lblNum4.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Black;
                }
                else if (max == num6)
                {
                    lblMax.Text = "Víc je: 6";
                    lblNum6.ForeColor = Color.Green;
                    lblNum5.ForeColor = Color.Black;
                    lblNum4.ForeColor = Color.Black;
                    lblNum3.ForeColor = Color.Black;
                    lblNum2.ForeColor = Color.Black;
                    lblNum1.ForeColor = Color.Black;
                }
            }
            #endregion

        }
        #endregion
    }
}
