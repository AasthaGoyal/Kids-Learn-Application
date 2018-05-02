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
    public partial class FormTemplate : Form
    {
        public FormTemplate()
        {
            InitializeComponent();
        }

        private void learnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testMyKnowledgeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblApplicationTitle.Text = ApplicationSettings.applicationTitle;
            this.Text = ApplicationSettings.companyName;
        }
    }
}
