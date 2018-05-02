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
    public partial class FormLearnEnglish : FormTemplateEnglish
    {
        public string WordToDisplay;

        string[] FruitsName = { "Apple", "Banana", "Orange", "Strawberry", "Kiwi" };
        public int length;
        public List<string> StoreWord = new List<string>();
         string word2 = " ";
         int wordLength = 0;
        string word = "";
        int counter = 0;
        int hangmanCounter = 0;
        //string[] StoreWord = new string[10];
        public FormLearnEnglish(string category)
        {
            InitializeComponent();

            if (category == "Fruits")
                lblCategory.Text = "Learn Fruits Names";
            else if (category == "Vegetables")
                lblCategory.Text = "Learn Vegetables Names";
            else if (category == "Colours")
                lblCategory.Text = "Learn Colours Names";
            else if (category == "Sports")
                lblCategory.Text = "Learn Sports Names";
            else
                lblCategory.Text = "Challenges";

            //LoadEngData();
        }

        //private void LoadEngData()
        //{
        //    WordToDisplay = ShowFruitName();
        //    length = WordToDisplay.Length;
            
        //    string dash = "___";
        //    for (int i = 1; i<length;i ++)
        //    {
        //        dash = dash + " ___ ";
        //        StoreWord.Add(dash);
        //    }
        //    foreach(string dashe in StoreWord)
        //         lblChallengeWord.Text = dashe;
            
        //}
        
        public void CheckAnswer(Button button)
        {
            string wordChar = button.Text;
            word2 = lblChallengeWord.Text;
            string word3 = "";

           bool found = false;
            for (int i = 0; i < wordLength; i++)
            {
                if (word[i].ToString() == wordChar)
                {
                    word3 = word3 + wordChar;
                    counter++;
                    found = true;
                }
                else
                {
                    word3 = word3 + word2[i];
                }
            }
            if (found == false)
            {

                pictureBoxHangman.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Hangman" + ++hangmanCounter + ".png");
            }
            if (hangmanCounter == 4)
            {
                MessageBox.Show("You are hangged!");
                loadData();
                hangmanCounter = 0;
                pictureBoxHangman.Image = Image.FromFile(@"Hangman0.png");
                ClearControls();
            }


            lblChallengeWord.Text = word3;
            button.BackColor = Color.Red;
            button.Enabled = false;

            if (counter == wordLength)
            {
                MessageBox.Show("Well-done!");
                loadData();
                ClearControls();
                counter = 0;
            }




        }

        private void loadData()
        {
            Random random = new Random();
            int index = random.Next(0, FruitsName.Length);
            word = FruitsName[index];
            picture.Image = Image.FromFile(@"C:\Users\Admin\Desktop\" + word + ".jpg");

            wordLength = word.Length;
            string questionMarks = "";
            for (int i = 0; i < wordLength; i++)
            {
                questionMarks = questionMarks + "?";
            }
            lblChallengeWord.Text = questionMarks;
        }

        //private void CheckAnswer(char button)
        //{
        //    List<Char> Letters = new List<Char>();//list used to store the individual characters
        //   //List<Char> FinalWord = new List<Char>();
        //     var chars = WordToDisplay.ToCharArray();
        //    for(int ctr=0;ctr<chars.Length;ctr++)
        //    {
        //        Letters.Add(chars[ctr]);
        //    }
        //    // List<char> TempList = new List<Char>();
        //    //List<String> TempList = new List<String>();
        //   String[] TempList = new String[10];

        //    for (int i=0;i<Letters.Count;i++)
        //    {
        //        if(button == Letters[i])
        //        {

        //            TempList[i] = button.ToString();
        //            textBox2.Text = TempList[i] + i.ToString();                     
        //        //  TempList.Add(button.ToString());
        //            int position = i;
        //            for(int j=0;j<length;j++)
        //            {
        //                if(j!=i)
        //                {
        //                    TempList[j] = "___";
        //                }
        //            }
        //            lblChallengeWord.Text = " ";
        //            foreach (string item in TempList)
        //            {
        //                lblChallengeWord.Text = item;
        //                listBox1.Items.Add(item);
        //            }
        //            //}
        //            //    textBox1.Text = "" + item;
        //            //   
        //        }
        //        //else
        //        //{
        //        //    MessageBox.Show("Wrong Choice!!!");
        //        //}

        //    }

        //}
        //private static string ShowFruitName()
        //{
        //    string FruitReturn = "";
        //    List<String> FruitsNames = new List<String>();
        //    FruitsNames.Add("Apple");
        //    FruitsNames.Add("Banana");
        //    FruitsNames.Add("Mango");
        //    FruitsNames.Add("Grapes");
        //    FruitsNames.Add("Kiwi");



        //    Random r1 = new Random();
        //    int FruitNo = r1.Next(0, 4);
        //    for (int i=0;i<5;i++)
        //    {
        //        if (FruitNo == i)
        //            FruitReturn = FruitsNames[i];
        //    }
        //    return FruitReturn;
        //}

        private void ClearControls()
        {
            buttonA.Enabled = true; buttonA.BackColor = Color.LightGreen;
            buttonB.Enabled = true; buttonB.BackColor = Color.LightGreen;
            buttonC.Enabled = true; buttonC.BackColor = Color.LightGreen;
            buttonD.Enabled = true; buttonD.BackColor = Color.LightGreen;
            buttonE.Enabled = true; buttonE.BackColor = Color.LightGreen;
            buttonF.Enabled = true; buttonF.BackColor = Color.LightGreen;
            buttonG.Enabled = true; buttonG.BackColor = Color.LightGreen;
            buttonH.Enabled = true; buttonH.BackColor = Color.LightGreen;
            buttonI.Enabled = true; buttonI.BackColor = Color.LightGreen;
            buttonJ.Enabled = true; buttonJ.BackColor = Color.LightGreen;
            buttonK.Enabled = true; buttonK.BackColor = Color.Green;
            buttonL.Enabled = true; buttonL.BackColor = Color.Green;
            buttonM.Enabled = true; buttonM.BackColor = Color.Green;
            buttonN.Enabled = true; buttonN.BackColor = Color.Green;
            buttonO.Enabled = true; buttonO.BackColor = Color.Green;
            buttonP.Enabled = true; buttonP.BackColor = Color.Green;
            buttonQ.Enabled = true; buttonQ.BackColor = Color.Green;
            buttonR.Enabled = true; buttonR.BackColor = Color.Green;
            buttonS.Enabled = true; buttonS.BackColor = Color.Green;
            buttonT.Enabled = true; buttonT.BackColor = Color.Green;
            buttonU.Enabled = true; buttonU.BackColor = Color.Green;
            buttonV.Enabled = true; buttonV.BackColor = Color.Green;
            buttonW.Enabled = true; buttonW.BackColor = Color.Green;
            buttonX.Enabled = true; buttonX.BackColor = Color.Green;
            buttonY.Enabled = true; buttonY.BackColor = Color.Green;
            buttonZ.Enabled = true; buttonZ.BackColor = Color.Green;
            buttonA.Enabled = true; buttonA.BackColor = Color.Green;
            buttonA.Enabled = true; buttonA.BackColor = Color.Green;
            buttonA.Enabled = true; buttonA.BackColor = Color.Green;
            buttonA.Enabled = true; buttonA.BackColor = Color.Green;
        }
        private void FormLearnEnglish_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonA_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonA);
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonB_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonB);

        }

        private void buttonC_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonC);
           
        }

        private void buttonD_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonD);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonE);
            
        }

        private void buttonF_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonF);
            
        }

        private void buttonG_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonG);
          
        }

        private void buttonH_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonH);
            
        }

        private void buttonI_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonI);
        }

        private void buttonJ_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonJ);
        }

        private void buttonK_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonK);
        }

        private void buttonL_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonL);
        }

        private void buttonM_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonM);
        }

        private void buttonN_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonN);
        }

        private void buttonO_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonO);
        }

        private void buttonP_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonP);
        }

        private void buttonQ_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonQ);
        }

        private void buttonR_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonR);
        }

        private void buttonS_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonS);
        }

        private void buttonT_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckAnswer(buttonT);
        }

        private void buttonT_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonT);
        }

        private void buttonU_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonU);
        }

        private void buttonV_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonV);
        }

        private void buttonW_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonW);
        }

        private void buttonX_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonX);
        }

        private void buttonY_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonY);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonZ_MouseClick(object sender, MouseEventArgs e)
        {
            CheckAnswer(buttonZ);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
