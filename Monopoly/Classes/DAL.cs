using System;
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

        //CRUD Game
        public List<Game> ReadGameList()
        {
            List<Game> gameList = new List<Game>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String Sql = "Select * FROM Game_Table";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Game game = new Game(Int32.Parse(reader[0].ToString()),
                                                            reader[1].ToString()
                                                        );
                            game.AddCategory(ReadCategory(Int32.Parse(reader[2].ToString())));

                            game.AddPlayers(ReadGamePlayerList(game));

                            gameList.Add(game);
                        }
                    }
                }
            }
            return gameList;
        }
        public void CreateGame(Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "INSERT INTO Game_Table(Name, CategoryId) VALUES (@Name, @CategoryId)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", game.Category.Id);
                    command.Parameters.AddWithValue("@Name", game.Name);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateGame()
        {

        }
        public void DeleteGame(Game game)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string SQL = "DELETE GamePlayer_Table WHERE GameId = @GameId;";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@GameId", game.Id);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DELETE Game_Table WHERE GameId = @GameId"; 
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        
        
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
        public Category ReadCategory(int Id)
        {
            Category category = new Category();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String Sql = "Select * FROM Category_Table WHERE CategoryId = @Id";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            category = new Category(Int32.Parse(reader[0].ToString()),
                                                        reader[1].ToString(),
                                                        reader[2].ToString()
                                                        );
                        }
                    }
                }
            }
            return category;
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
                    cmd.CommandText = "DELETE Category_Table WHERE CategoryId = @Id";
                    cmd.Parameters.AddWithValue("@Id", category.Id);                        //misschien overbodig
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



        // CRUD Player
        public List<Player> ReadPlayerList()
        {
            List<Player> playerList = new List<Player>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "SELECT * FROM Player_Table";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player player = new Player(Int32.Parse(reader[0].ToString()),
                                                   reader[1].ToString()
                                                   );
                            playerList.Add(player);
                        }
                    }
                }
            }
            return playerList;
        }
        public List<Player> ReadGamePlayerList(Game game)
        {
            List<Player> playerList = new List<Player>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "SELECT Player_Table.* FROM Player_Table, GamePlayer_Table WHERE GamePlayer_Table.GameId = @GameId AND Player_Table.PlayerId = GamePlayer_Table.PlayerId;";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, connection))
                {
                    cmd.Parameters.AddWithValue("@GameId", game.Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player player = new Player(Int32.Parse(reader[0].ToString()),
                                                   reader[1].ToString()
                                                   );
                            playerList.Add(player);
                        }
                    }
                }
            }
            return playerList;
        }
        public void CreatePlayer(Player player, Game game)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string SQL = "INSERT INTO Player_Table (Name, Money) VALUES (@Name, @Money);";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", player.Name);
                    cmd.Parameters.AddWithValue("@Money", player.Money);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT CAST (@@Identity AS INT);";
                    int id = (int)cmd.ExecuteScalar();
                    player.Edit(id, player.Name);

                    cmd.CommandText = "INSERT INTO GamePlayer_Table (GameId, PlayerId) VALUES (@GameId, @PlayerId);";
                    cmd.Parameters.AddWithValue("@GameId", game.Id);
                    cmd.Parameters.AddWithValue("@PlayerId", player.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdatePlayer(Player player)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                string SQL = "UPDATE Player_Table SET Name = @Name,  Money = @Money WHERE PlayerId = @PlayerId";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerId", player.Id);
                    cmd.Parameters.AddWithValue("@Name", player.Name);
                    cmd.Parameters.AddWithValue("@Money", player.Money);             
                    cmd.ExecuteNonQuery();
                }


            }
        }
        public void DeletePlayer(Player player, Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string SQL = "DELETE GamePlayer_Table WHERE PlayerId = @PlayerId AND GameId = @GameId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(SQL, connection))
                {
                    command.Parameters.AddWithValue("@PlayerId", player.Id);
                    command.Parameters.AddWithValue("@GameId", game.Id);
                    command.ExecuteNonQuery();
                }
            }
        }



        // READ Plot
        public List<Plot> ReadStandardPlotList()
        {
            //Read first 29 plots
            List<Plot> plotList = new List<Plot>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string Sql = "SELECT TOP 29 * FROM Plot_Table";
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
        public List<Plot> ReadPlotList(Board board)
        {
            //Read Plots that belong to boardId
            List<Plot> plotList = new List<Plot>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string Sql = "SELECT * FROM Plot_Table WHERE BoardId = @BoardId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(Sql, connection))
                {
                    command.Parameters.AddWithValue("@BoardId", board.Id);
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
        public List<Card> ReadStandardCardList()
        {
            //Read first 15 cards
            List<Card> cardList = new List<Card>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string Sql = "SELECT TOP 15 * FROM Card_Table";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cardList.Add(new Card(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString()));
                        }
                    }
                }
            }
            return cardList;
        }
        public List<Card> ReadCardList(Board board)
        {
            List<Card> cardList = new List<Card>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string Sql = "SELECT * FROM Card_Table WHERE BoardId = @BoardId";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, conn))
                {
                    cmd.Parameters.AddWithValue("@BoardId", board.Id);
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
