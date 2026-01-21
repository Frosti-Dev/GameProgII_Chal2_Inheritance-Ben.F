using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal2_Inheritance_Ben.F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] answers = { "1", "1", "1", "1", "1", "1", "1", "1" };
            Question question1 = new Question("wow", "amazing");
            MultipleChoiceQuestion multipleChoice = new MultipleChoiceQuestion("optionss wow", answers, 1);

            //question1.Ask();
            //question1.CheckAnswer();

            multipleChoice.Ask();
            multipleChoice.CheckAnswer();
        }
    }
}
