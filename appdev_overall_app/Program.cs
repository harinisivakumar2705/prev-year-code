using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace appdev_overall_app
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// take screenshots of testing
        /// make screen video with audio explaining code
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}

