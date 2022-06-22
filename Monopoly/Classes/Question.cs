﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        public Category Category { get; set; }
        private DAL dal;

        public Question(int id, string questionText, string answer)
        {
            Id = id;
            QuestionText = questionText;
            Answer = answer;
        }

        public Question()
        {
            dal = new DAL();
        }

        public bool CheckAnswer()
        {
            return true;
        }

        public void AddCategory(Category _category)
        {
            Category = _category;
        }

        public void Create(Question question)
        {
            dal.CreateQuestion(question);
        }

        public void Update(Question question)
        {
            dal.UpdateQuestion(question);
        }

        public void Delete(Question question)
        {
            dal.DeleteQuestion(question);
        }

        public List<Question> GetList(Category category)
        {
            return dal.ReadQuestionList(category);
        }
    }
}
