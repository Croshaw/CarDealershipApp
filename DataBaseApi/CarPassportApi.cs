using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    internal class CarPassportApi
    {
        public bool isCarPassExist(string id)
        {
            return DataBase.QueryInDataBase($"SELECT passport_car_number FROM passports_cars WHERE passport_car_id='{id}'");
        }
        public static DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT pts.passport_car_id, car.car_id,CONCAT(car.car_trademark,' ', car.car_model) AS Машина, people.people_id, CONCAT(people.people_surname, ' ', SUBSTRING (people.people_name,1,1), '. ', SUBSTRING (people.people_patronymic,1,1), '.') AS Владелец, pts.passport_car_number AS Номер FROM passports_cars pts INNER JOIN cars car ON pts.passport_car_car_id =car.car_id JOIN peoples people ON pts.passport_car_owner_id=people.people_id ORDER BY passport_car_id ASC");
        }
        public static int AddCarPass(int IdCar, int IdOwner, string Number)
        {
            return DataBase.QueryElement($"INSERT INTO passports_cars (passport_car_car_id, passport_car_owner_id, passport_car_number) VALUES ('{IdCar}','{IdOwner}','{Number}')");
        }
        public static int UpdateCarPass(int Id, int IdCar, int IdOwner, string Number)
        {
            return DataBase.QueryElement($"UPDATE passports_cars SET passport_car_car_id ='{IdCar}', passport_car_owner_id ='{IdOwner}', passport_car_number = '{Number}' WHERE passport_car_id={Id}");
        }
        public static int DeleteCarPass(int Id)
        {
            return DataBase.QueryElement($"DELETE FROM passports_cars WHERE passport_car_id={Id}");
        }
    }
}
