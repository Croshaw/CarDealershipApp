using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    internal class EmployeeApi
    {
        public bool isEmployeeExist(string id)
        {
            return DataBase.QueryInDataBase($"SELECT employee_surname FROM employees WHERE employee_id='{id}'");
        }
        public static DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT em.employee_id, em.employee_surname AS Фамилия, em.employee_name AS Имя, em.employee_patronymic AS Отчество, em.employee_phone AS Телефон, em.employee_birthdate AS \"День рождения\", pos.positions_name AS Должность, em.employee_address AS Адрес FROM employees em INNER JOIN positions pos ON em.employee_position_id=pos.positions_id ORDER BY employee_id ASC");
        }
        public static int AddEmployee(string Surname, string Name, string Patronymic, string Phone, string Date, int idPos, string Address)
        {
            return DataBase.QueryElement($"INSERT INTO employees (employee_surname, employee_name, employee_patronymic, employee_phone, employee_birthdate, employee_position_id, employee_address) VALUES ('{Surname}','{Name}','{Patronymic}', '{Phone}', '{Date}', '{idPos}','{Address}')");
        }
        public static int UpdateEmployee(int Id, string Surname, string Name, string Patronymic, string Phone, string Date, int idPos, string Address)
        {
            return DataBase.QueryElement($"UPDATE employees SET employee_surname ='{Surname}', employee_name ='{Name}', employee_patronymic = '{Patronymic}', employee_phone = '{Phone}', employee_birthdate = '{Date}', employee_position_id = '{idPos}', employee_address = '{Address}'  WHERE employee_id={Id}");
        }
        public static int DeleteEmployee(int Id)
        {
            return DataBase.QueryElement($"DELETE FROM employees WHERE employee_id={Id}");
        }
    }
}
