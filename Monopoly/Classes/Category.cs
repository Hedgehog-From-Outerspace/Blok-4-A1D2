using System;
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
        private DAL dal;

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            QuestionList = new List<Question>();
        }

        public Category()
        {
            dal = new DAL();
        }

        public void AddQuestion(Question question)
        {
            QuestionList.Add(question);
            question.AddCategory(this);
        }

        public void Create(Category category)
        {
            dal.CreateCategory(category);
        }

        public void Update(Category category)
        {
            dal.UpdateCategory(category);
        }

        public void Delete(Category category)
        {
            dal.DeleteCategory(category);
        }

        public List<Category> GetList()
        {
            return dal.ReadCategoryList();
        }
    }
}
