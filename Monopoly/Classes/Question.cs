using System;
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

        public Question(int id, string questionText, string answer)
        {
            Id = id;
            QuestionText = questionText;
            Answer = answer;
        }

        public bool CheckQuestion()
        {
            return true;
        }

        public void AddCategory(Category _category)
        {
            Category = _category;
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

        public List<Question> GetList()
        {
            return new List<Question>();
        }
    }
}
