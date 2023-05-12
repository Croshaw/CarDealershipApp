using System.Data;

namespace CarDealershipApp.DataBaseApi
{
    internal class PeopleApi
    {
        public bool isPeopleExist(string id)
        {
            return DataBase.QueryInDataBase($"SELECT people_surname FROM peoples WHERE people_id='{id}'");
        }
        public static DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT people_id, people_surname AS Фамилия, people_name AS Имя, people_patronymic AS Отчество, people_phone AS Телефон, people_birthdate AS \"День рождения\", people_address AS Адрес FROM peoples ORDER BY people_id ASC");
        }
        public static int AddPeople(string Surname, string Name, string Patronymic, string Phone, string Date, string Address)
        {
            return DataBase.QueryElement($"INSERT INTO peoples (people_surname, people_name, people_patronymic, people_phone, people_birthdate, people_address) VALUES ('{Surname}','{Name}','{Patronymic}', '{Phone}', '{Date}', '{Address}')");
        }
        public static int UpdatePeople(int Id, string Surname, string Name, string Patronymic, string Phone, string Date, string Address)
        {
            return DataBase.QueryElement($"UPDATE peoples SET people_surname ='{Surname}', people_name ='{Name}', people_patronymic = '{Patronymic}', people_phone = '{Phone}', people_birthdate = '{Date}', people_address = '{Address}'  WHERE people_id={Id}");
        }
        public static int DeletePeople(int Id)
        {
            return DataBase.QueryElement($"DELETE FROM peoples WHERE people_id={Id}");
        }
    }
}
