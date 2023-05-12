using CarDealershipApp.Entity;
using System.Data;

namespace CarDealershipApp.DataBaseApi.Tables
{
    internal class CarsTable
    {
        public DataTable DataTable { get; set; }
        public List<Car> CarsList { get; set; }

        public CarsTable() 
        {
            try
            {
                DataBase.OpenConnection();
            }
            catch { MessageBox.Show("Ошибка подключения к БД"); return; }
            DataTable = CarApi.GetTable();
            DataBase.CloseConnection();
            CarsList = new List<Car>();
            foreach (DataRow row in DataTable.Rows)
            {
                var cells = row.ItemArray;
                CarsList.Add(new Car((int)cells[0], (string)cells[1], (string)cells[2], cells[3] == DBNull.Value ? "" : (string)cells[3]));
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
                foreach (var item in CarsList)
                {
                    if (item.Id == -1 && item.IsDelete) continue;
                    if (item.Id == -1)
                    {
                        CarApi.AddCar(item.Trademark, item.Model, item.Series);
                    }
                    else if (item.IsDelete)
                    {
                        CarApi.DeleteCar(item.Id);
                    }
                    else if (item.IsEdited)
                    {
                        CarApi.UpdateCar(item.Id, item.Trademark, item.Model, item.Series);
                    }
                }
                return true;
            }
            catch { return false; }
            finally { DataBase.CloseConnection(); }
        }
    }
}
