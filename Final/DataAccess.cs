using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Final
{
    class DataAccess
    {
        private static GameInfo gameInfo;

        private static SqlConnection dbConn;
        private static string sConnection;

        private static SqlCommand dbCmd;
        private static string sql;

        private static SqlDataReader dbReader;

        public static void OpenDB()
        {
            try
            {
                // set up the connection to the database
                sConnection =
                    "Data Source=stusql-cis151-101-fa21.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
                    "Initial Catalog=kc0932947; User Id=kc0932947; Password=932947";
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
        }

        public static void CloseDB()
        {
            try
            {
                // close the database reader 
                dbReader.Close();
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        public static SqlDataReader Readmember()
        {
            try
            {
                // set up the sql command to run
                sql = "SELECT * FROM Game";

                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                // run the sql command and return result set in reader
                dbReader = dbCmd.ExecuteReader();
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
            return dbReader;        // return to satisfy compiler
        }

        public static ArrayList GetGameInfo()
        {
            // open the connection
            OpenDB();
            dbReader = Readmember();
            ArrayList GameArray = new ArrayList();
            while (dbReader.Read())
            {
                gameInfo = new GameInfo(
                            dbReader["TotalScore"].ToString(),
                            dbReader["PlayerOneName"].ToString(),
                            dbReader["PlayerOneScore"].ToString(),
                            dbReader["PlayerTwoName"].ToString(),
                            dbReader["PlayerTwoScore"].ToString(),
                            dbReader["PlayerThreeName"].ToString(),
                            dbReader["PlayerThreeScore"].ToString());

                GameArray.Add(gameInfo);
            }

            CloseDB();
            return GameArray;
        }

        public static void AddGameInfo(GameInfo toAdd)      // adds package info to the sql server
        {
            OpenDB();
            sql = "INSERT INTO Game(TotalScore, PlayerOneName, PlayerOneScore, PlayerTwoName, PlayerTwoScore, PlayerThreeName, PlayerThreeScore)  VALUES('" +

                    toAdd.TotalScore + "', '" +
                    toAdd.PlayerOneName + "', '" +
                    toAdd.PlayerOneScore + "', '" +
                    toAdd.PlayerTwoName + "', '" +
                    toAdd.PlayerTwoScore + "', '" +
                    toAdd.PlayerThreeName + "', '" +
                    toAdd.PlayerThreeScore + "');";

            dbCmd = new SqlCommand();
            dbCmd.CommandText = sql;
            dbCmd.Connection = dbConn;

            // run the sql command and return result set in reader
            dbReader = dbCmd.ExecuteReader();

            CloseDB();
        }
    }
}
