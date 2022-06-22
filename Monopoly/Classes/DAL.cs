using System;
using System.Collections.Generic;
using.System.Data.SqlClient;
using System.Linq;
using System.Text;
using.System.Threading;
using System.Threading.Tasks;

namespace Monopoly
{ 
    public class DAL
    {
        public string connectionString = "Data Source=.;Initial Catalog=StudieApp;Integrated Security=True"
        public List<Category> CategoryList = new List<Category>();
        public List<Question> QuestionList = new List<Question>();
        public List<Card> CardList = new List<Card>();
        public List<Plot> PlotList = new List<Plot>();
          
        
        public DAL()
        {

        }


        public void RefreshDALList()
        {
            FillCategoryListFromDataBase();
            FillQuestionListFromDataBase();
            FillCardListFromDataBase();
            FillPlotListFromDataBase();
            
        }





        // CRUD Category
        public void FillCategoryListFromDataBase()
        {
            this.CategoryList.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryId, Name, Description FROM Category_Table";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoryList.Add(new Category(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString() ));
                        }
                    }
                }
            }
        }


        public void CreateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "INSERT INTO Category_Table(Name) VALUES (@Name)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", category.Id);
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Description", category.Description);
                    command.ExecuteNonQuery();
                }
            }
            FillCategoryListFromDataBase();
        }


        public void UpdateCategory (Category category)
        {
             using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "UPDATE Category_Table SET Name = @Name, Description = @Description WHERE ID = @ID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", category.Id);
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Description", category.Description);
                    command.ExecuteNonQuery();
                }
            }
            FillCategoryListFromDataBase();
        }


        public void DeleteCategory (Category category)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                string SQL = "DELETE Question_Table WHERE CategoryId = @CategoryId";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand( SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", category.ID);
                    cmd.ExecuteNonQuery () ;
                }
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "DELETE Category_Table WHERE CategoryId = @CategoryId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", category.Id);
                    command.ExecuteNonQuery();
                }
            }
            FillCategoryListFromDataBase();
        }





        // CRUD Question
        public void FillQuestionListFromDataBase()
        {
            this.QuestionList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT QuestionId, QuestionText, Answer, CategoryId FROM Question_Table";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        Category toAddCategory = null;

                        while (dataReader.Read())
                        {
                            try
                            {
                                foreach (Category category in CategoryList)
                                {
                                    if (category.Id == Int32.Parse(reader[3].ToString()))
                                    {
                                        toAddCategory = category;
                                    }
                                }
                            }
                            catch
                            {
                                toAddCategory = new Category(0, "", "");
                            }
                            QuestionList.Add(new Question(Int32.Parse(dataReader[0].ToString()), dataReader[1].ToString(), dataReader[2].ToString(), toAddCategory));
                        }
                    }
                }
            }
        }


        public void CreateQuestion (Question question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                string SQL = "INSERT INTO Question_Table(QuestionText, Answer, CategoryId) VALUES (@QuestionText, @Answer, @CategoryId)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {                   
                    command.Parameters.AddWithValue("@QuestionId", question.Id);
                    command.Parameters.AddWithValue("@QuestionText", question.QuestionText);
                    command.Parameters.AddWithValue("@Answer", question.Answer);
                    command.Parameters.AddWithValue("@CategoryId", question.Category);
                    command.ExecuteNonQuery();
                }
            }
            FillQuestionListFromDataBase();
        }


        public void UpdateQuestion (Question question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "UPDATE Question_Table SET QuestionText = @QuestionText, Answer = @Answer, CategoryId = @CategoryId WHERE QuestionId = @QuestionId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {   
                    command.Parameters.AddWithValue("@QuestionId", question.Id);
                    command.Parameters.AddWithValue("@QuestionText", question.QuestionText);
                    command.Parameters.AddWithValue("@Answer", question.Answer);
                    command.Parameters.AddWithValue("@CategoryId", question.Category);
                    command.ExecuteNonQuery();
                }
                FillQuestionListFromDataBase();
            }

        }


        public void DeleteQuestion (Question question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "DELETE Question_Table WHERE QuestionId = @QuestionId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@QuestionId", question.Id);
                    command.ExecuteNonQuery();
                }
            }
            FillQuestionListFromDataBase();
        }

        



        // READ Plot
        public void FillPlotListFromDataBase()
        {
            this.PlotList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT PlotId, PlotType FROM Plot_Table";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {                  
                            PlotList.Add(new Plot(Int32.Parse(dataReader[0].ToString()), dataReader[1].ToString()));
                        }
                    }
                }
            }
        }





        // READ Cards
        public void FillCardListFromDataBase()
        {
            this.CardList.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CardId, CardText, Effect FROM Card_Table";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CardList.Add(new Card(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString() ));
                        }
                    }
                }
            }
        }
    }
}
