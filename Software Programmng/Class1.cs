using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Programmng
{
    class DatabaseConnection

    {
        //
        //attributes
        //
        private static DatabaseConnection _instance;

        private static string connectionStr;

        private SqlConnection connectionToDB;

        private SqlDataAdapter dataAdapter;

        public static string ConnectionStr
        {
            set { connectionStr = value; }
        }

        public static DatabaseConnection getDatabaseConnection()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;

        }
        public void openConnection()
        {
            connectionToDB = new SqlConnection(connectionStr);

            connectionToDB.Open();


        }
        
        public void closeConnection()
        {
            connectionToDB.Close();

        }
        public DataSet getDataSet(string SqlStatement)
        {
            DataSet dataSet;

            dataAdapter = new
            System.Data.SqlClient.SqlDataAdapter(SqlStatement, connectionToDB);
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;


        }
         
        public DataSet getDataSet_Command(string sqlStatement)
        {
            DataSet dataSet = new DataSet();

            using (connectionToDB = new SqlConnection(connectionStr))
            {
                connectionToDB.Open();
                SqlCommand command = new SqlCommand(sqlStatement, connectionToDB);

                SqlDataReader reader = command.ExecuteReader();

                dataSet.Load(reader, LoadOption.PreserveChanges, "Login Details");

                connectionToDB.Close();

            }
            return dataSet; 

            void insert(string sqlQuery, string userid, string password)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlQuery;
                command.Parameters.Add(new SqlParameter("UserID", userid));
                command.Parameters.Add(new SqlParameter("Password", password));

                using (connectionToDB = new SqlConnection(connectionStr));
                {
                    connectionToDB.Open();
                    command.Connection = connectionToDB;
                    int n = command.ExecuteNonQuery();
                    Console.WriteLine("n-" + n);
                    connectionToDB.Close();
                }

            }
        }

    }
}
