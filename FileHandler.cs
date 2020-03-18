using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace AskSprint1_1.Views
{
    public class FileHandler
    {
        List<Question> questions;
        List<Answer> answers;
        public FileHandler()
        {
            questions = new List<Question>();
            answers = new List<Answer>();
            QuestionsReader();
            AnswerReader();
        }
        private void QuestionsReader()
        {
            StreamReader sr = new StreamReader("questions.csv");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Question q = new Question(line);
                questions.Add(q);
            }
        }
        private void AnswerReader()
        {
            StreamReader sr = new StreamReader("answers.csv");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Answer a = new Answer(line);
                answers.Add(a);
            }
        }
    }
}
