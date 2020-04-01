using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AskSprint1_1.Services
{
    public class InMemoryQuestionsService : IQuestionsService
    {
        [Required]
        
        private List<Question> _questions = new List<Question>();
        private int ID = 0;
        public InMemoryQuestionsService()
        {
            List<string> empty = new List<string>();
            empty.Add("gyász");
            empty.Add("valami");
            empty.Add("ami talán már menni fog");

            Question q = new Question(ID + 1, "How smol is ur PP?", "I wonder if that's visible at all...",empty);
            _questions.Add(q);
            this.ID += 1;
            q = new Question(ID + 1, "How high is Wiz Khalifa?", "Could he be up in the mountains right now?");
            _questions.Add(q);
            this.ID += 1;
            q = new Question(ID + 1,"Is this a loss?","I II II I _" );
            this.ID += 1;
            _questions.Add(q);

        }
        public int GetId()
        {
            return this.ID;
        }
        public List<Question> GetAll()
        {
            return _questions;
        }
        public Question GetOne(int id)
        {
            return _questions.Where(q => q.ID == id).First();
        }
        public List<Question> AddOne(string title,string message)
        {
            this.ID += 1;

            var question = new Question (ID,title,message );
            _questions.Add(question);
            return _questions;
        }
        public List<Question> Add1Answer(int id, string message="Valami")
        {
            foreach (var q in _questions)
            {
                if (q.ID==id)
                {
                    q.Answers.Add(message);
                }
            }
            return _questions;
        }
        public int NumberOfAnswers(int id)
        {
            List<Question> questions = _questions;
            int length = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].ID == id && questions[i].Answers.Count > 0)
                {
                    length = questions[i].Answers.Count;
                }
            }
            return length;
        }
    }
}
