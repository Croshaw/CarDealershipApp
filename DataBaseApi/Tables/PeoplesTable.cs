using CarDealershipApp.Entity;
using System.Data;

namespace CarDealershipApp.DataBaseApi.Tables
{
    internal class PeoplesTable
    {
        public DataTable DataTable { get; set; }
        public List<People> PeoplesList { get; set; }

        public PeoplesTable() 
        {
            try
            {
                DataBase.OpenConnection();
            }
            catch { MessageBox.Show("Ошибка подключения к БД"); return; }
            DataTable = PeopleApi.GetTable();
            DataBase.CloseConnection();
            PeoplesList = new List<People>();
            foreach (DataRow row in DataTable.Rows)
            {
                var cells = row.ItemArray;
                PeoplesList.Add(new People((int)cells[0], (string)cells[1], (string)cells[2], (string)cells[3], (string)cells[4], (DateTime)cells[5], (string)cells[6]));
            }
        }

        public bool SaveTable()
        {
            try
            {
                DataBase.OpenConnection();
            }
            catch { MessageBox.Show("Ошибка подключения к БД"); return false; }
            try
            {
                foreach (var item in PeoplesList)
                {
                    if (item.Id == -1 && item.IsDelete) continue;
                    if (item.Id == -1)
                    {
                        PeopleApi.AddPeople(item.Surname, item.Name, item.Patronymic, item.Phone, item.BirthDate.ToString("dd/MM/yyyy"), item.Address);
                    }
                    else if (item.IsDelete)
                    {
                        PeopleApi.DeletePeople(item.Id);
                    }
                    else if (item.IsEdited)
                    {
                        PeopleApi.UpdatePeople(item.Id, item.Surname, item.Name, item.Patronymic, item.Phone, item.BirthDate.ToString("dd/MM/yyyy"), item.Address);
                    }
                }
                return true;
            }
            catch(Exception ex) { return false; }
            finally { DataBase.CloseConnection(); }
        }
    }
}
