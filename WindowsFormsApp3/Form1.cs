/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Se definește un namespace WindowsFormsApp3, care conține codul pentru aplicație.
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       // Clasa principală este Form1, care reprezintă fereastra principală a aplicației.
        public Form1()
        {
            //Constructorul clasei Form1 initializează componentele ferestrei.
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Evenimentul button1_Click deschide o fereastră nouă (Form2) când butonul este apăsat.
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }


        //Evenimentul button2_Click deschide un fișier de ajutor (CarConfigurator.chm) atunci când butonul este apăsat.
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CarConfigurator.chm");
            // MessageBox.Show("Bine ați venit în simulatorul de configurare auto!\n\nAcest simulator vă permite să explorați diferite opțiuni de configurare pentru mașini, oferindu-vă o experiență interactivă și virtuală.\n\nPuteți urma următorii pași pentru a utiliza aplicația:\n\n1. Selectați modelul de mașină dorit din lista disponibilă.\n2. Personalizați caracteristicile mașinii, cum ar fi culoarea caroseriei, jantele, interiorul și sistemul audio.\n3. Explorați opțiunile suplimentare, cum ar fi dotările și pachetele opționale.\n4. Vizualizați și salvați configurarea finală a mașinii.\n\nPentru orice întrebări sau asistență, vă rugăm să ne contactați. Vă dorim o experiență plăcută!", "Ajutor");
        }
        //Evenimentul button3_Click închide aplicația atunci când butonul este apăsat.
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
