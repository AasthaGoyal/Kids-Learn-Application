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
    public partial class FormMainEnglish : FormTemplateEnglish
    {
        public FormMainEnglish()
        {
            InitializeComponent();
        }

        private void FormMainEnglish_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btmFruits_Click(object sender, EventArgs e)
        {
            new FormLearnEnglish("Fruits").Show();
        }

        private void btmVegetables_Click(object sender, EventArgs e)
        {
            new FormLearnEnglish("Vegetables").Show();
        }

        private void btmColours_Click(object sender, EventArgs e)
        {
            new FormLearnEnglish("Colours").Show();
        }

        private void btmSports_Click(object sender, EventArgs e)
        {
            new FormLearnEnglish("Sports").Show();
        }

        private void btmChallenge_Click(object sender, EventArgs e)
        {
            new FormLearnEnglish("Challenges").Show();
        }
    }
}
