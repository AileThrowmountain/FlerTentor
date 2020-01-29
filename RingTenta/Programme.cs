using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingTenta
{
    class Programme
    {
        public static Random random = new Random();
        List<Question> questions { get; set; } = new List<Question>();
        public int Jackpot { get; set; }


        public Programme()
        {


            for (int i = 1; i < 51; i++)
            {
                Question question = new Question(i);
                i = question.Number;
                questions.Add(question);
            }
            TakenQuestions();
            GenerateHalfChanceQuestions();
            GenerateWholeChanceQuestions();
            GenerateQuarterChanceQuestions();
        }
        public void TakenQuestions()
        {
            foreach (Question currentQuestion in questions) // Loopa igenom ALLA frågor
            {
                int randomValue = random.Next(0, 2);

                if (randomValue == 0)
                {
                    currentQuestion.IsTaken = false;

                }

                else if (randomValue == 1)
                {
                    currentQuestion.IsTaken = true;
                }
            }

        }
        public List<Question> GetQuestions()
        { 
            List<Question> onlyUnansweredQs = new List<Question>();

            foreach (Question currentQ in questions)
            {
                if (currentQ.IsTaken == false)
                {
                    onlyUnansweredQs.Add(currentQ);
                }
            }


            return onlyUnansweredQs;
        }
        public void GenerateHalfChanceQuestions()
        {

            int i = 0;
            int rand;
            while (i < 2)
            {

                rand = random.Next(questions.Count);

                if (questions[rand].Points == 1)
                {
                    questions[rand].Points = 10;
                    i++;
                }

            }

        }
        public void GenerateWholeChanceQuestions()
        {
            int i = 0;
            int rand;
            while (i < 1)
            {
                rand = random.Next(questions.Count);

                if (questions[rand].Points == 1)
                {
                    questions[rand].Points = 20;
                    i++;
                }
            }
        }

        public void GenerateQuarterChanceQuestions()
        {

            int i = 0;
            int rand;
            while (i < 4)
            {

                rand = random.Next(questions.Count);

                if (questions[rand].Points == 1)
                {
                    questions[rand].Points = 5;
                    i++;
                }

            }
        }
    }
}
