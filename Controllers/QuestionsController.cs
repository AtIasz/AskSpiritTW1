using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AskSprint1_1.Models;
using AskSprint1_1.Services;

namespace AskSprint1_1.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly ILogger<QuestionsController> _logger;
        private readonly IQuestionsService _questionsService;

        public QuestionsController(ILogger<QuestionsController> logger, IQuestionsService questionService)
        {
            _questionsService = questionService;
            _logger = logger;
        }

        public IActionResult All()
        {
            var questions = _questionsService.GetAll();
            return View(questions);
        }

        
    }
}
