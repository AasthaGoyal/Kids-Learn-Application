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
    public partial class FormTemplateEnglish : Form
    {
        public FormTemplateEnglish()
        {
            InitializeComponent();
        }

        private void FormTemplateEnglish_Load(object sender, EventArgs e)
        {
            lblEnglishApplicationTitle.Text = ApplicationSettings.EnglishApplicationTitle;
            this.Text = ApplicationSettings.companyName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEnglishApplicationTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
