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
    public partial class FormMain : FormTemplate
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btmAddition_Click(object sender, EventArgs e)
        {
            new FormCalculator("+").Show();
            //creating an object and showing the form 
        }

        private void btmSubtraction_Click(object sender, EventArgs e)
        {
            new FormCalculator("-").Show();
        }

        private void btmMultiplication_Click(object sender, EventArgs e)
        {
            new FormCalculator("*").Show();
        }

        private void btmDivision_Click(object sender, EventArgs e)
        {
            new FormCalculator("/").Show();
        }

        private void btmTestMySkills_Click(object sender, EventArgs e)
        {
            new FormCalculator("TestMySkills").Show();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANKS FOR PLAYING!!!!!!!!!!!!!!!!1");
            Application.Exit();
        }
    }
}
