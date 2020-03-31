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
            _questions.Add(new Question { ID = ID+1, Title = "How smol is ur PP?", Message = "I wonder if that's visible at all..." });
            this.ID += 1;
            _questions.Add(new Question { ID = ID + 1, Title = "How high is Wiz Khalifa?", Message = "Could he be up in the mountains right now?" });
            this.ID += 1;
            _questions.Add(new Question { ID = ID + 1, Title = "Is this a loss?", Message = "I II II I _" });
            this.ID += 1;

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

            var question = new Question { ID = ID, Title =title, Message =message };
            _questions.Add(question);
            return _questions;
        }
        
    }
}
