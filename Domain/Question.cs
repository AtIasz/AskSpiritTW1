using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AskSprint1_1
{
    public class Question
    {
        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        
    }
}
