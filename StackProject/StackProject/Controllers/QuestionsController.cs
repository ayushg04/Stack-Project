using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StackProject.Controllers
{
    public class QuestionsController : Controller
    {
        StackContext st = new StackContext();
        public IActionResult Index()
        {
            return View(st.QuestionTables.ToList());
        }
        public IActionResult QAnswers(string question)
        {
            QuestionTable qt = st.QuestionTables.Find(question);
            return View(qt);
        }
        [HttpPost]
        public IActionResult QAnswers(AnswerTable answer)
        {
            st.AnswerTables.Add(answer);
            st.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddQuestions()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQuestions(QuestionTable questionTable)
        {
            if (string.IsNullOrEmpty(questionTable.Question) || string.IsNullOrEmpty(questionTable.Description))
            {
                ModelState.AddModelError("", "Fill Complete Details");
                return RedirectToAction("AddQuestions");
            }
            using(var con = new StackContext())
            {
                bool isValid = con.QuestionTables.Any(x => x.Question == questionTable.Question);
                if (isValid)
                {
                    return View();
                }
                con.QuestionTables.Add(questionTable);
                con.SaveChanges();
                return RedirectToAction("Index","Questions");
            }
        }
    }
}
