/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
