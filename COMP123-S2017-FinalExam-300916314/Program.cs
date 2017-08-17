using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Bal Krishna Dhakal
 * Date: August 17, 2017
 * StudentID: 300916314
 * Description: Final Test Project 
 * Version: 0.1 Final Term Project Created
 */

namespace COMP123_S2017_FinalExam_300916314
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PickHighestCardForm());
        }
    }
}
