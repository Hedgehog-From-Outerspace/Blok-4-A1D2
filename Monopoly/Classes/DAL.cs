﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monopoly
{ 
    public class DAL
    {
        public string connectionString = "Data Source=.;Initial Catalog=StudieApp;Integrated Security=True";

        // CRUD Category
        public List<Category> ReadCategoryList()
        {
            List<Category> categoryList = new List<Category>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String Sql = "Select * FROM Category_Table";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryList.Add(new Category(Int32.Parse(reader[0].ToString()),
                                                        reader[1].ToString(), 
                                                        reader[2].ToString())
                                                        );
                        }
                    }
                }
            }
            return categoryList;
        }
        public void CreateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "INSERT INTO Category_Table(Name, Description) VALUES (@Name, @Description)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", category.Id);
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Description", category.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCategory (Category category)
        {
             using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "UPDATE Category_Table SET Name = @Name, Description = @Description WHERE CategoryId = @CategoryId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", category.Id);
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Description", category.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteCategory (Category category)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                string SQL = "DELETE Question_Table WHERE CategoryId = @CategoryId";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand( SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", category.Id);
                    cmd.ExecuteNonQuery () ;
                    cmd.CommandText = "DELETE Category_Table WHERE CategoryId = @CategoryId";
                    cmd.Parameters.AddWithValue("@CategoryId", category.Id);                        //misschien overbodig
                    cmd.ExecuteNonQuery ();
                }
            }
        }

        // CRUD Question
        public List<Question> ReadQuestionList(Category category)
        {
            List<Question> questionList = new List<Question>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string Sql = "SELECT * FROM Question_Table WHERE CategoryId = @Id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(Sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", category.Id);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Question question = new Question(Int32.Parse(dataReader[0].ToString()),
                                                        dataReader[1].ToString(),
                                                        dataReader[2].ToString()
                                                        );
                            questionList.Add(question);
                            category.AddQuestion(question);
                        }
                    }
                }
            }
            return questionList;
        }
        public void CreateQuestion (Question question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                string SQL = "INSERT INTO Question_Table(QuestionText, Answer, CategoryId) VALUES (@QuestionText, @Answer, @CategoryId)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {                   
                    command.Parameters.AddWithValue("@QuestionText", question.QuestionText);
                    command.Parameters.AddWithValue("@Answer", question.Answer);
                    command.Parameters.AddWithValue("@CategoryId", question.Category.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateQuestion (Question question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "UPDATE Question_Table SET QuestionText = @QuestionText, Answer = @Answer WHERE QuestionId = @QuestionId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {   
                    command.Parameters.AddWithValue("@QuestionId", question.Id);
                    command.Parameters.AddWithValue("@QuestionText", question.QuestionText);
                    command.Parameters.AddWithValue("@Answer", question.Answer);
                    command.ExecuteNonQuery();
                }
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
        }

        //CRUD Game
        public List<Game> ReadGameList()
        {
            List<Game> gameList = new List<Game>();
            return gameList;
        }
        public void CreateGame()
        {

        }
        public void UpdateGame()
        {

        }
        public void DeleteGame()
        {

        }

        //CRUD Board

        //CRUD Player

        // READ Plot
        public List<Plot> ReadPlotList()
        {
            List<Plot> plotList = new List<Plot>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string Sql = "SELECT * FROM Plot_Table";
                connection.Open();
                using (SqlCommand command = new SqlCommand(Sql, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {                  
                            plotList.Add(new Plot(Int32.Parse(dataReader[0].ToString()), dataReader[1].ToString()));
                        }
                    }
                }
            }
            return plotList;
        }

        // READ Cards
        public List<Card> ReadCardList()
        {
            List<Card> cardList = new List<Card>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string Sql = "SELECT * FROM Card_Table";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cardList.Add(new Card(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString() ));
                        }
                    }
                }
            }
            return cardList;
        }
    }
}
