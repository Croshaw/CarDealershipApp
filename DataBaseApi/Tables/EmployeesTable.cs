using CarDealershipApp.Entity;
using System.Data;

namespace CarDealershipApp.DataBaseApi.Tables
{
    internal class EmployeesTable
    {
        public DataTable DataTable { get; set; }
        public List<Employee> EmployeesList { get; set; }
        public List<Position> PositionsList { get; set; }

        public EmployeesTable() 
        {
            try
            {
                DataBase.OpenConnection();
            }
            catch { MessageBox.Show("Ошибка подключения к БД"); return; }
            DataTable = EmployeeApi.GetTable();
            DataTable dtTemp = PositionApi.GetTable();
            DataBase.CloseConnection();
            EmployeesList = new List<Employee>();
            PositionsList = new List<Position>();
            foreach (DataRow row in dtTemp.Rows)
            {
                var cells = row.ItemArray;
                PositionsList.Add(new Position((int)cells[0], (string)cells[1]));
            }
            foreach (DataRow row in DataTable.Rows)
            {
                var cells = row.ItemArray;
                EmployeesList.Add(new Employee((int)cells[0], (string)cells[1], (string)cells[2], (string)cells[3], (string)cells[4], (DateTime)cells[5], PositionsList.First(x=> x.Name== (string)cells[6]), (string)cells[7]));
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
                foreach (var item in EmployeesList)
                {
                    if (item.Id == -1 && item.IsDelete) continue;
                    if (item.Id == -1)
                    {
                        EmployeeApi.AddEmployee(item.Surname, item.Name, item.Patronymic, item.Phone, item.BirthDate.ToString("dd/MM/yyyy"), item.Position.Id, item.Address);
                    }
                    else if (item.IsDelete)
                    {
                        EmployeeApi.DeleteEmployee(item.Id);
                    }
                    else if (item.IsEdited)
                    {
                        EmployeeApi.UpdateEmployee(item.Id, item.Surname, item.Name, item.Patronymic, item.Phone, item.BirthDate.ToString("dd/MM/yyyy"), item.Position.Id, item.Address);
                    }
                }
                return true;
            }
            catch { return false; }
            finally { DataBase.CloseConnection(); }
        }
    }
}
