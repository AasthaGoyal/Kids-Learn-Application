using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearnMath
{
    class ApplicationLogic
    {
       
        public static List<int> getAnswers(int rightAnswer, int totalAnswers)
        {
            List<int> answers = new List<int>();

            for (int i = 0; i < totalAnswers; i++)
            {
                int ans = findWrongAnswer(answers, rightAnswer, totalAnswers);
                answers.Add(ans);
            }
            Random findPositionOfRightAnswer = new Random();
            int position = findPositionOfRightAnswer.Next(0, totalAnswers);
            answers[position] = rightAnswer;
            return answers;
        }

        private static int findWrongAnswer(List<int> list, int rightAnswer, int totalAnswers)
        {
            Random random = new Random();
            int wrongAnswer = random.Next(rightAnswer - (totalAnswers - 5), rightAnswer + (totalAnswers + 5));
            if (wrongAnswer == rightAnswer)
            {
                wrongAnswer = findWrongAnswer(list, rightAnswer, totalAnswers);
            }
            else
            {
                foreach (int number in list)
                {
                    Console.WriteLine("Number in list:" + number + "Wrong Answer: " + wrongAnswer);

                    if (number == wrongAnswer)
                    {
                        wrongAnswer = findWrongAnswer(list, rightAnswer, totalAnswers);
                        break;
                    }
                }

            }
            return wrongAnswer;



        }

        public static string getRandomOperator()
        {
            Random r = new Random();
            int randomOperator = r.Next(1, 4);
            if (randomOperator == 1)
                return "+";
            else if (randomOperator == 2)
                return "-";
            else if (randomOperator == 3)
                return "*";
            else
                return "/";
        }
    }
}
