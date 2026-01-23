using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal2_Inheritance_Ben.F
{
    internal class Question
    {
        //variables 
        string _questionText;
        string _answerText;

        //constructor
        public Question(string QuestionText, string AnswerText)
        {
            _questionText = QuestionText;
            _answerText = AnswerText;
        } 

        //methods
        public void Ask()
        {
            Console.WriteLine(_questionText);
        }

        public virtual bool CheckAnswer()
        {
            string playerAnswer = Console.ReadLine();

            if(playerAnswer.ToUpper() == _answerText.ToUpper())
            {
                Debug.WriteLine($"{playerAnswer} = correct");
                return true;
            }

            else
            {
                Debug.WriteLine($"{playerAnswer} = incorrect");
                return false;
            }
        }
    }

    class MultipleChoiceQuestion : Question
    {
        //variables
        string[] _answerOptions;
        int _correctAnswer;

        //constructors
        public MultipleChoiceQuestion(string QuestionText, string[] AnswerOptions, int CorrectAnswer) : base(QuestionText, CorrectAnswer.ToString())
        {
            _answerOptions = AnswerOptions;
            _correctAnswer = CorrectAnswer;
        }

        public override bool CheckAnswer()
        {
            foreach(string answer in _answerOptions)
            {
                Console.WriteLine(answer);
            }

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key) 
                {
                    case ConsoleKey.D1:
                        if (_correctAnswer == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }


                    case ConsoleKey.D2:
                        if (_correctAnswer == 2)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D3:
                        if (_correctAnswer == 3)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D4:
                        if (_correctAnswer == 4)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D5:
                        if (_correctAnswer == 5)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D6:
                        if (_correctAnswer == 6)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D7:
                        if (_correctAnswer == 7)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D8:
                        if (_correctAnswer == 8)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case ConsoleKey.D9:
                        if (_correctAnswer == 9)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }
            }
        }
    }

    class TrueOrFalseQuestion : Question
    {
        bool _answerAsBool;

        public TrueOrFalseQuestion(string questionText, bool answerAsBool) : base(questionText, answerAsBool.ToString())
        {
            _answerAsBool = answerAsBool;
        }

        public override bool CheckAnswer()
        {
            string playerAnswer = Console.ReadLine();

            if (playerAnswer.ToUpper() == _answerAsBool.ToString().ToUpper())
            {
                Debug.WriteLine($"{playerAnswer} = correct");
                return true;
            }


            else
            {
                Debug.WriteLine($"{playerAnswer} = incorrect");
                return false;
            }

        }
    }
}
