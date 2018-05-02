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
    public partial class FormCalculator : FormTemplate
    {
        int level = 1;
        int counter = 0;
        int score = 0;
        int number1, number2, result;
        int time = ApplicationSettings.timeDuration;
        public FormCalculator(string operation)
        {
            InitializeComponent();

            if (operation == "+")
            {
                lblCalculate.Text = "Learn Addition";
                labelOperator.Text = "+";
            }
            else if (operation == "-")
            {
                lblCalculate.Text = "Learn Subtraction";
                labelOperator.Text = "-";
            }
            else if (operation == "*")
            {
                lblCalculate.Text = "Learn Multiplication";
                labelOperator.Text = "*";
            }
            else if (operation == "/")
            {
                lblCalculate.Text = "Learn Division";
                labelOperator.Text = "/";
            }
            else
            {
                lblCalculate.Text = "Test My Knowledge";
                labelOperator.Text = ApplicationLogic.getRandomOperator();
            }

            loadData();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void checkAnswer(object sender)
        {
            //time = ApplicationSettings.timeDuration;

            Button btn = (Button)sender;
            int userAnswer = Convert.ToInt32(btn.Text);
            if(userAnswer == result)
            {
                //do right answer
                MessageBox.Show("Right Answer!");
                score++;
                lblScore.Text = score.ToString();
            }
            else
            {
                //do wrong answer
                MessageBox.Show("Wrong Answer!!! Right answer is =" + result);
            }
            loadData();// add another question

        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time --;
            lblTimer.Text = "Timer: " + time;

            if (time == 0)
            {
                loadData();
                time = ApplicationSettings.timeDuration;
            } 
        }

        private void lblCalculate_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestionNo_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            
                if (lblCalculate.Text == "Test My Knowledge")
                labelOperator.Text = ApplicationLogic.getRandomOperator();

            counter++;
            lblQuestionNo.Text = "Question #:" + counter;
            lblLevel.Text = "Level #:" + level;
            lblScore.Text = "Score #:" + score;
            if (counter % 5 == 0)
                level++;

            
            Random random = new Random();
             number1 = random.Next(1,10) * level;
             number2 = random.Next(1,10) * level;


            if ((labelOperator.Text == "-") && (number1 < number2))
            {
                number1 = number1 + number2;
                label1.Text = number1.ToString();
            }
            else if (labelOperator.Text == "/")
            {
                number1 = number1 * number2;
                label1.Text = number1.ToString();
            }
            else
            {
                label1.Text = number1.ToString();
                
            }

            label2.Text = number2.ToString();// = "" + number2 is another method to conbvert it


            int findButton = random.Next(0, 9);
            int PutButton = random.Next(0, 9);

            if (labelOperator.Text == "+")
                result = number1 + number2;
            else if (labelOperator.Text == "-")
                result = number1 - number2;
            else if (labelOperator.Text == "*")
                result = number1 * number2;
            else if (labelOperator.Text == "/")
                result = number1 / number2;

            //int[] answers = new int[10];
            //for(int i=0;i<10;i++)
            //{
            //    answers[i] = random.Next(0, 10);
            //}

            List<int> answers = ApplicationLogic.getAnswers(result,9);
            button1.Text = "" + answers[0];
            button2.Text = "" + answers[1];
            button3.Text = "" + answers[2];
            button4.Text = "" + answers[3];
            button5.Text = "" + answers[4];
            button6.Text = "" + answers[5];
            button7.Text = "" + answers[6];
            button8.Text = "" + answers[7];
            button9.Text = "" + answers[8];


            //if (PutButton == 0)
            //    button1.Text = "" + result;
            //else if (PutButton == 1)
            //    button2.Text = "" + result;
            //else if (PutButton == 2)
            //    button3.Text = "" + result;
            //else if(PutButton == 3)
            //    button4.Text = "" + result;
            //else if (PutButton == 4)
            //    button5.Text = "" + result;
            //else if (PutButton == 5)
            //    button6.Text = "" + result;
            //else if (PutButton == 6)
            //    button7.Text = "" + result;
            //else if(PutButton == 7)
            //    button8.Text = "" + result;
            //else
            //    button9.Text = "" + result;
            time = ApplicationSettings.timeDuration;

        }


        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
