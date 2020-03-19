using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskSprint1_1.Services
{
    public class InMemoryQuestionsService : IQuestionsService
    {
        private List<Question> _questions = new List<Question>();
        public InMemoryQuestionsService()
        {
            _questions.Add(new Question { ID = 1, Title = "How smol is ur PP?", Message = "I wonder if that's visible at all..." });
            _questions.Add(new Question { ID = 2, Title = "How high is Wiz Khalifa?", Message = "Could he be up in the mountains right now?" });
            _questions.Add(new Question { ID = 3, Title = "Is this a loss?", Message = "I II \n II I _" });
        }
        public List<Question> GetAll()
        {
            return _questions;
        }

        public Question GetOne(int id)
        {
            return _questions.Where(q => q.ID == id).First();
        }
    }
}
