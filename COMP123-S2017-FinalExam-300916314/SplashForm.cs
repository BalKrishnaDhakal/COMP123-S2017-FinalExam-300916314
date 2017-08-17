using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name: Bal Krishna Dhakal
 * Date: August 17, 2017
 * StudentID: 300916314
 * Description: Final Test Project
 * Version: 0.2 SplashForm Timer Tick Method is Created
 */
namespace COMP123_S2017_FinalExam_300916314
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the SplashForm Timer Tick Methods
        /// This enables the Timer property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
        }
    }
}
