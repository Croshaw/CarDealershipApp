using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    internal class SaleApi
    {
        public bool isSaleExist(string id)
        {
            return DataBase.QueryInDataBase($"SELECT sale_car_pas_id FROM passports_cars WHERE sale_id='{id}'");
        }
        public static DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT sale.sale_id, pts.passport_car_id, em.employee_id, sale.sale_buyer_id,CONCAT(car.car_trademark,' ', car.car_model) AS Машина, " +
                $"CONCAT(peoplecar.people_surname, ' ', SUBSTRING (peoplecar.people_name,1,1), '. ', SUBSTRING (peoplecar.people_patronymic,1,1), '.') AS Владелец, " +
                $"CONCAT(em.employee_surname, ' ', SUBSTRING (em.employee_name,1,1), '. ', SUBSTRING (em.employee_patronymic,1,1), '.') AS Продавец, sale.sale_cost AS Цена, CONCAT(peoplebuyer.people_surname, ' ', " +
                $"SUBSTRING (peoplebuyer.people_name,1,1), '. ', SUBSTRING (peoplebuyer.people_patronymic,1,1), '.') AS Покупатель, sale.sale_date AS Дата, sale.sale_status AS Статус FROM sales sale " +
                $"INNER JOIN passports_cars pts ON pts.passport_car_id=sale.sale_car_pas_id JOIN employees em ON sale.sale_employee_id=em.employee_id JOIN cars car ON pts.passport_car_car_id=car.car_id " +
                $"JOIN peoples peoplecar ON pts.passport_car_owner_id=peoplecar.people_id LEFT JOIN peoples peoplebuyer ON sale.sale_buyer_id = peoplebuyer.people_id ORDER BY sale.sale_id ASC");
        }
        public static DataTable GetTable(string Filter)
        {
            return DataBase.GetDataTable($"SELECT sale.sale_id, pts.passport_car_id, em.employee_id, sale.sale_buyer_id,CONCAT(car.car_trademark,' ', car.car_model) AS Машина, " +
                $"CONCAT(peoplecar.people_surname, ' ', SUBSTRING (peoplecar.people_name,1,1), '. ', SUBSTRING (peoplecar.people_patronymic,1,1), '.') AS Владелец, " +
                $"CONCAT(em.employee_surname, ' ', SUBSTRING (em.employee_name,1,1), '. ', SUBSTRING (em.employee_patronymic,1,1), '.') AS Продавец, sale.sale_cost AS Цена, CONCAT(peoplebuyer.people_surname, ' ', " +
                $"SUBSTRING (peoplebuyer.people_name,1,1), '. ', SUBSTRING (peoplebuyer.people_patronymic,1,1), '.') AS Покупатель, sale.sale_date AS Дата, sale.sale_status AS Статус FROM sales sale " +
                $"INNER JOIN passports_cars pts ON pts.passport_car_id=sale.sale_car_pas_id JOIN employees em ON sale.sale_employee_id=em.employee_id JOIN cars car ON pts.passport_car_car_id=car.car_id " +
                $"JOIN peoples peoplecar ON pts.passport_car_owner_id=peoplecar.people_id LEFT JOIN peoples peoplebuyer ON sale.sale_buyer_id = peoplebuyer.people_id WHERE " + Filter + $" ORDER BY sale.sale_id ASC");
        }
            public static int AddSale(int IdPasCar, int IdEmployee, long Cost, int? IdBuyer, string Date, string Status)
        {
            if (IdBuyer == null)
                return DataBase.QueryElement($"INSERT INTO sales (sale_car_pas_id, sale_employee_id, sale_cost, sale_status) VALUES ('{IdPasCar}','{IdEmployee}','{Cost}','{Status}')");
            else
                return DataBase.QueryElement($"INSERT INTO sales (sale_car_pas_id, sale_employee_id, sale_cost, sale_buyer_id, sale_date, sale_status) VALUES ('{IdPasCar}','{IdEmployee}','{Cost}','{IdBuyer},'{Date}','{Status}')");
        }
        public static int UpdateSale(int Id, int IdPasCar, int IdEmployee, long Cost, int? IdBuyer, string Date, string Status)
        {
            if(IdBuyer== null)
                return DataBase.QueryElement($"UPDATE sales SET sale_car_pas_id ='{IdPasCar}', sale_employee_id ='{IdEmployee}', sale_cost = '{Cost}', sale_buyer_id = NULL, sale_date = NULL, sale_status = '{Status}' WHERE sale_id={Id}");
            else
                return DataBase.QueryElement($"UPDATE sales SET sale_car_pas_id ='{IdPasCar}', sale_employee_id ='{IdEmployee}', sale_cost = '{Cost}', sale_buyer_id = '{IdBuyer}', sale_date = '{Date}', sale_status = '{Status}' WHERE sale_id={Id}");
        }
        public static int DeleteSale(int Id)
        {
            return DataBase.QueryElement($"DELETE FROM sales WHERE sale_id={Id}");
        }
    }
}
