using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    internal class PositionApi
    {
        public bool isPositionExist(string id)
        {
            return DataBase.QueryInDataBase($"SELECT positions_name FROM positions WHERE positions_id='{id}'");
        }
        public static DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT positions_id, positions_name AS Наименование FROM positions ORDER BY positions_id ASC");
        }
        public static int AddPosition(string Name)
        {
            return DataBase.QueryElement($"INSERT INTO positions (name) VALUES ('{Name}')");
        }
        public static int UpdatePosition(int Id, string Name)
        {
            return DataBase.QueryElement($"UPDATE positions SET positions_name = '{Name}' WHERE positions_id={Id}");
        }
        public static int DeletePosition(int Id)
        {
            return DataBase.QueryElement($"DELETE FROM positions WHERE positions_id={Id}");
        }
    }
}
