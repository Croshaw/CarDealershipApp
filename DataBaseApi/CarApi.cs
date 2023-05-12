using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    internal class CarApi
    {
        public bool isCarExist(string id)
        {
            return DataBase.QueryInDataBase($"SELECT car_id FROM cars WHERE car_id='{id}'");
        }
        public static DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT car_id, car_trademark AS Марка, car_model AS Модель, car_series AS Серия FROM cars ORDER BY car_id ASC");
        }
        public static int AddCar(string Trademark, string Model, string Series)
        {
            return DataBase.QueryElement($"INSERT INTO cars (car_trademark, car_model, car_series) VALUES ('{Trademark}','{Model}','{Series}')");
        }
        public static int UpdateCar(int Id, string Trademark, string Model, string Series)
        {
            return DataBase.QueryElement($"UPDATE cars SET car_trademark ='{Trademark}', car_model ='{Model}', car_series = '{Series}' WHERE car_id={Id}");
        }
        public static int DeleteCar(int Id)
        {
            return DataBase.QueryElement($"DELETE FROM cars WHERE car_id={Id}");
        }
    }
}
