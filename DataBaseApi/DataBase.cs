using Npgsql;
using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    class DataBase
    {
        private static NpgsqlConnection dbConnection = null;
        private static NpgsqlCommand dbCommand = null;
        private static NpgsqlDataAdapter dataAdapter = null;
        private static NpgsqlDataReader dataReader = null;
        private static string connectionString = null;

        //Строка подключения БД.
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        //Открывает соединение с БД
        public static void OpenConnection()
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException("Connection string cannot be null!");
            if (dbConnection == null) dbConnection = new NpgsqlConnection(connectionString);//Поменять
            dbConnection.Open();
        }

        //Закрываем соедениение с БД, если оно открыто
        public static void CloseConnection()
        {
            if (dbConnection != null && dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
        }

        //Получаем таблицу из БД по Запросу который мы передаем в качестве параметра
        public static DataTable GetDataTable(string query)
        {
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException("Query cannot be null!");
            dataAdapter = new NpgsqlDataAdapter(query, dbConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds.Tables[0];
        }

        //Получаем список элементов из БД по запросу, чаще всего используем, чтобы получить 1 элемент. Пример пароль по логину.
        public static List<string> GetDataInList(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException("Query cannot be null!");
            dbCommand = new NpgsqlCommand(query, dbConnection);
            dataReader = dbCommand.ExecuteReader();
            List<string> tempList = new List<string>();
            while (dataReader.Read())
            {
                tempList.Add(dataReader.GetValue(0).ToString());
            }
            dataReader.Close();
            return tempList;
        }
        //Проверка есть ли запись в таблице БД
        public static bool QueryInDataBase(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException("Query cannot be null!");
            bool result = false;
            dbCommand = new NpgsqlCommand(query, dbConnection);
            dataReader = dbCommand.ExecuteReader();
            if (dataReader.Read())
                result = true;
            dataReader.Close();
            return result;
        }

        //Для удаления, изменения и добавления элементов в БД
        public static int QueryElement(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException("Query cannot be null!");

            dbCommand = new NpgsqlCommand(query, dbConnection);
            return dbCommand.ExecuteNonQuery();
        }

        //Для получение числа записей в таблице, по запросу
        public static int CountQueryElement(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException("Query cannot be null!");

            dbCommand = new NpgsqlCommand(query, dbConnection);
            return Convert.ToInt32(dbCommand.ExecuteScalar());
        }
    }
}
