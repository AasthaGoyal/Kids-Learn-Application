using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearnMath
{
    public partial class FrontMainForm : Form
    {
        public FrontMainForm()
        {
            InitializeComponent();
        }

        private void lblMainApplicationTitle_Click(object sender, EventArgs e)
        {

        }

        private void btmMaths_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
        }

        private void btmEnglish_Click(object sender, EventArgs e)
        {
            new FormMainEnglish().Show();
        }
    }
}
