using CarDealershipApp.Entity;
using System.Data;

namespace CarDealershipApp.DataBaseApi.Tables
{
    internal class CarsPassportsTable
    {
        public DataTable DataTable { get; set; }
        public List<CarPassport> CarPassportList { get; set; }
        public CarsTable CarsTable { get; set; }
        public PeoplesTable OwnerTable { get; set; }

        public CarsPassportsTable() 
        {
            try
            {
                DataBase.OpenConnection();
            }
            catch { MessageBox.Show("Ошибка подключения к БД"); return; }
            DataTable = CarPassportApi.GetTable();
            DataBase.CloseConnection();
            CarPassportList = new List<CarPassport>();
            CarsTable = new CarsTable();
            OwnerTable = new PeoplesTable();
            foreach (DataRow row in DataTable.Rows)
            {
                var cells = row.ItemArray;
                CarPassportList.Add(new CarPassport((int)cells[0], CarsTable.CarsList.First(x=> x.Id == (int)cells[1]), OwnerTable.PeoplesList.First(x => x.Id == (int)cells[3]), (string)cells[5]));
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
                foreach (var item in CarPassportList)
                {
                    if (item.Id == -1 && item.IsDelete) continue;
                    if (item.Id == -1)
                    {
                        CarPassportApi.AddCarPass(item.Car.Id, item.Owner.Id, item.Number);
                    }
                    else if (item.IsDelete)
                    {
                        CarPassportApi.DeleteCarPass(item.Id);
                    }
                    else if (item.IsEdited)
                    {
                        CarPassportApi.UpdateCarPass(item.Id, item.Car.Id, item.Owner.Id, item.Number);
                    }
                }
                return true;
            }
            catch { return false; }
            finally { DataBase.CloseConnection(); }
        }
    }
}
