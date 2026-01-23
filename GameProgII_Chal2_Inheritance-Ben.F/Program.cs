using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProgII_Chal2_Inheritance_Ben.F
{
    internal class Program
    {
        static int curQuestion = 0;
        static float QuestionsCorrect = 0f;
        static float currentScore = 100f;
        static bool stillPlaying = true;

        static List<Question> Questions = new List<Question>();

        static void AddQuestions()
        {
            //Multiple Choice
            string[] answers1 = { "1: Omori", "2: Sunny", "3: Kel", "4: Hero", "5: Alex" };
            string[] answers2 = { "1: Omori", "2: Aubrey", "3: Alex", "4: Mari", "5: Polly" };
            string[] answers3 = { "1: Omori", "2: Kel", "3: Hero", "4: Sunny", "5: Basil" };

            MultipleChoiceQuestion MultipleChoice1 = new MultipleChoiceQuestion("What is the protagonist's default name?", answers1, 2);
            Questions.Add(MultipleChoice1);

            MultipleChoiceQuestion MultipleChoice2 = new MultipleChoiceQuestion("Which character is the protagonist's sister?", answers2, 4);
            Questions.Add(MultipleChoice2);

            MultipleChoiceQuestion MultipleChoice3 = new MultipleChoiceQuestion("Which character do you play as in the HEADSPACE?", answers3, 1);
            Questions.Add(MultipleChoice3);

            //True or False

            TrueOrFalseQuestion TrueOrFalse1 = new TrueOrFalseQuestion("True or False? The first area you see is called the Black Space.", false);
            Questions.Add(TrueOrFalse1);

            TrueOrFalseQuestion TrueOrFalse2 = new TrueOrFalseQuestion("True or False? When opening the front door in the day time, the first person you see is Kel.", true);
            Questions.Add(TrueOrFalse2);

            TrueOrFalseQuestion TrueOrFalse3 = new TrueOrFalseQuestion("True or False? This game is a psychological horror game.", true);
            Questions.Add(TrueOrFalse3);


            //text Answer
            Question Question1 = new Question("Who does the protagonist have a crush on?", "Aubrey");
            Questions.Add(Question1);

            Question Question2 = new Question("Who is the stranger?", "Basil");
            Questions.Add(Question2);

            Question Question3 = new Question("Who is 'something'?", "Mari");
            Questions.Add(Question3);

            Question QuestionF = new Question("Who is Sunny?", "Omori");
            Questions.Add(QuestionF);

        }

        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Current Question: {curQuestion}              Score: {currentScore}%");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            AddQuestions();

            Console.Write("Welcome to the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Omori ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Quiz!");

            Console.ReadKey(true);
            Console.Clear();

            while (stillPlaying)
            {
                QuestionsCorrect = 0;
                currentScore = 100f;

                foreach (Question question in Questions)
                {
                    curQuestion += 1;
                    ShowHUD();

                    question.Ask();

                    if (question.CheckAnswer() == true)
                    {
                        QuestionsCorrect += 1;
                    }

                    Console.Clear();

                    if (QuestionsCorrect == 0)
                    {
                        currentScore = 0f;
                    }

                    else
                    {
                        currentScore = QuestionsCorrect / curQuestion * 100;
                    }
                }

                //Scores
                Console.WriteLine("Your Score is....");
                Thread.Sleep(500);
                Console.WriteLine(QuestionsCorrect / Questions.Count * 100 + "%");

                if (QuestionsCorrect == 0)
                {
                    Console.WriteLine("Wow...that's...really bad...");

                }

                else if (QuestionsCorrect == 10)
                {
                    Console.WriteLine("PERFECT SCORE! WELL DONE!!");
                }

                else if (QuestionsCorrect > 8)
                {
                    Console.WriteLine("Close! Next time you get it, for sure!");
                }

                else
                {
                    Console.WriteLine("Nice Try!");
                }

                while (true)
                {
                    Console.WriteLine("Do you want to play again? (Y/N)");

                    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        curQuestion = 0;
                        Console.Clear();
                        break;
                    }

                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        stillPlaying = false;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Enter 'Y' for Yes or 'N' for No");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Bye Bye");
        }
    }
}
