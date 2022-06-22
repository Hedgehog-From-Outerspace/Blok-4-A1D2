﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Question> QuestionList { get; set; }

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            QuestionList = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            QuestionList.Add(question);
            question.AddCategory(this);
        }

        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public List<Category> GetList()
        {
            return new List<Category>();
        }
    }
}
