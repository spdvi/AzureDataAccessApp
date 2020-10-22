using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDataAccessWinformsUI
{
    public static class DataAccess
    {

        public static List<GameModel> GetAllGames()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PersonGamesDB"].ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<GameModel> games = new List<GameModel>();

                string sql = "SELECT Id, NameOfGame, Description FROM dbo.Games";
                games = connection.Query<GameModel>(sql).ToList();
                return games;
            }
        }

        public static void InsertNewGame(string nameOfGame, string description)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PersonGamesDB"].ConnectionString;

            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new { nameOfGame = nameOfGame, description = description };
                connection.Execute("dbo.spGames_InsertNewGame", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
