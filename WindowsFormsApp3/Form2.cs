/**************************************************************************
 *                                                                        *
 *  File:        Form2.cs                                                 *
 *  Copyright:   (c) Lazar, Eftasiu,Cocalea,Ungureanu                     *
 *                                                                        *
 *                                                                        *
 *  Description: This car configurator simulator is a software application*
 *  or tool that allows users to virtually customize and configure        *
 *  a car according to their preferences and desired specifications.      *       
 *                                                                        *
 *                                                                        *

 **************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        //Aceste variabile memorează opțiunile selectate de utilizator referitoare la culoarea mașinii, jantele, culoarea interioară și transmisia.
        private string selectedColor = "guards-red";
        private string selectedWheel = "19-cayman-s-wheels";
        private string selectedInteriorColor = "black-interior";
        private string selectedTransmission = "manual-trans";

        //Aceasta este o funcție care construiește calea către imaginea mașinii bazată pe opțiunile selectate de utilizator.
        private string GetImagePath()
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission,  "ext-1.jpg");
            return imagePath;
        }

        //Această funcție actualizează imaginea afișată în caseta de imagine (pictureBox1) cu imaginea corespunzătoare calei obținute din funcția GetImagePath().
        private void UpdateImage()
        {
          
            string imagePath = GetImagePath();

            if (File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                 pictureBox1.Image = image;
                
            }
            else
            {
                MessageBox.Show("Fișierul de imagine nu a fost găsit.");
            }
           
        }
        //Această funcție calculează și actualizează prețul total al mașinii pe baza opțiunilor selectate de utilizator.
        private void UpdatePrice()
        {

           double basePrice = 80000.00; // Preț de bază
            double equipmentPrice = 0.00; // Prețul echipamentelor (opțiunilor selectate)

            // Calculați prețul echipamentelor pe baza opțiunilor selectate
            if (checkBox1.Checked)
            {
                equipmentPrice += 550.00; // Prețul opțiunii 1
            }

            if (checkBox2.Checked)
            {
                equipmentPrice += 1800.00; // Prețul opțiunii 2
            }
            if (checkBox3.Checked)
            {
                equipmentPrice += 1356.00; // Prețul opțiunii 3
            }
            if (checkBox4.Checked)
            {
                equipmentPrice += 1000.00; // Prețul opțiunii 4
            }
            if (radioButton1.Checked)
            {
                equipmentPrice += 0.00; // Prețul transmisiei manuale
            }
            if (radioButton2.Checked)
            {
                equipmentPrice += 3200.00; // Prețul transmisiei automate
            }
          
            double transport = 1700.00;
            // Calculați prețul total
            double totalPrice = basePrice + equipmentPrice+transport;


            // Actualizați valoarea în label
            label15.Text = equipmentPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US")); 
            label17.Text = totalPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }
        //Această funcție actualizează culoarea interioară selectată pe baza opțiunii selectate de utilizator.
        private void UpdateInteriorColor()
        {
            if (radioButton4.Checked)
            {
                selectedInteriorColor = "black-interior";
            }
            else if (radioButton5.Checked)
            {
                selectedInteriorColor = "bordeaux-red-interior";
            }
            else if (radioButton6.Checked)
            {
                selectedInteriorColor = "expresso-interior";
            }
            
        }
        //Această funcție actualizează tipul de transmisie selectat pe baza opțiunii selectate de utilizator.
        private void UpdateTransmission()
        {
            if (radioButton7.Checked)
            {
                selectedTransmission = "manual-trans";
            }
            else if (radioButton8.Checked)
            {
                selectedTransmission = "pdk";
            }
           
        }
        

        public Form2()
        {
         InitializeComponent();
        }
        //mai jos este redat implementarea pentru Buttons,  checkBoxs, etc
        private void button1_Click(object sender, EventArgs e)
        {
            
            selectedColor = "guards-red";
            UpdateImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            selectedColor = "racing-yellow";
            UpdateImage();
        }

    

        private void button3_Click(object sender, EventArgs e) {
           
            selectedColor = "carrera-white-metallic";
            UpdateImage(); ;
         }



         private void button4_Click(object sender, EventArgs e)
        {
           
            selectedColor = "jet-black-metallic";
            UpdateImage();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            selectedColor = "miami-blue";
            UpdateImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedTransmission = "manual-trans";
            UpdatePrice();
            UpdateImage();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedTransmission = "pdk";
           
            UpdatePrice();
            UpdateImage();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            string imagePath = @"C:\images\cayman-model\guards-red\19-cayman-s-wheels\black-interior\manual-trans\ext-1.jpg";

            //Verifică dacă fișierul există în calea specificată
            if (File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Fișierul de imagine nu a fost găsit.");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
          
        }

        private void label15_Click(object sender, EventArgs e)
        {

            UpdatePrice();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission, "ext-1.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectedWheel = "19-cayman-s-wheels";
            UpdateImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedWheel = "20-911-turbo-wheels";
            UpdateImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedWheel = "20-carrera-s-wheels";
            UpdateImage();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selectedInteriorColor = "black-interior";
            UpdateImage();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedInteriorColor = "bordeaux-red-interior";
            UpdateImage();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectedInteriorColor = "espresso-interior";
            UpdateImage();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission, "ext-2.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission, "ext-3.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission, "ext-4.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission, "int-1.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string baseDirectory = @"C:\images\cayman-model\";
            string imagePath = Path.Combine(baseDirectory, selectedColor, selectedWheel, selectedInteriorColor, selectedTransmission, "int-2.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void label17_Click(object sender, EventArgs e)
        {

            UpdatePrice();
        }

        private void label16_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Seteteaza calea unde va fi salvat documentul pdf
            string filePath = @"C:\pdf\file.pdf";

            try
            {
                // Creeaza un  PDF document
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 12, XFontStyle.Regular); //fontul documentului
                gfx.DrawString("Configuratia voastra a fost salvata cu succes!Vom trimite configuratia unui dealer auto!", font, XBrushes.Black, new XRect(50, 50, page.Width, page.Height), XStringFormats.TopLeft);
                document.Save(filePath);
                MessageBox.Show("PDF saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving PDF: " + ex.Message);
            }
        }
    }
    }
    

