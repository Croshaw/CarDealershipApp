using CarDealershipApp.Entity;
using System.Data;
using System.Numerics;
using System.Text;

namespace CarDealershipApp.DataBaseApi.Tables
{
    internal class SalesTable
    {
        public DataTable DataTable { get; set; }
        public List<Sale> SalesList { get; set; }
        public CarsPassportsTable CarsPassportsTable { get; set; }
        public EmployeesTable EmployeesTable { get; set; }
        private StringBuilder Filter { get; set; }

        public SalesTable() 
        {
            try
            {
                DataBase.OpenConnection();
            }
            catch { MessageBox.Show("Ошибка подключения к БД"); return; }
            DataTable = SaleApi.GetTable();
            DataBase.CloseConnection();
            SalesList = new List<Sale>();
            Filter = new StringBuilder();
            CarsPassportsTable = new CarsPassportsTable();
            EmployeesTable = new EmployeesTable();
            foreach (DataRow row in DataTable.Rows)
            {
                var cells = row.ItemArray;
                SalesList.Add(new Sale((int)cells[0], CarsPassportsTable.CarPassportList.First(x=> x.Id == (int)cells[1]), EmployeesTable.EmployeesList.First(x => x.Id == (int)cells[2]), (long)cells[7], cells[3] == DBNull.Value ? null : CarsPassportsTable.OwnerTable.PeoplesList.FirstOrDefault(x => x.Id == (int)cells[3] ), cells[9]==DBNull.Value ? null : (DateTime)cells[9], (string)cells[10]));
            }
        }

        public void ApplyFilter()
        {
            if (Filter.Length < 1) DataTable = SaleApi.GetTable();
            else DataTable = SaleApi.GetTable(Filter.ToString());
            Filter.Clear();
        }

        public void FilterBySurnameOwner(string surnameOwner)
        {
            if(Filter.Length>0) Filter.Append(" AND ");
            Filter.Append($"peoplecar.people_surname = '{surnameOwner}'");
        }

        public void FilterByNumberCar(string numberCar)
        {
            if (Filter.Length > 0) Filter.Append(" AND ");
            Filter.Append($"pts.passport_car_number = '{numberCar}'");
        }
        public void FilterByTrademarkCar(string trademarkCar)
        {
            if (Filter.Length > 0) Filter.Append(" AND ");
            Filter.Append($"car.car_trademark = '{trademarkCar}'");
        }
        public void FilterByCost(long cost1, long cost2)
        {
            if(Filter.Length>0) Filter.Append(" AND ");
            Filter.Append($"sale.sale_cost BETWEEN '{Math.Min(cost1,cost2)}' AND '{Math.Max(cost1, cost2)}'");
        }
        public void FilterByStatus(string status)
        {
            if(Filter.Length>0) Filter.Append(" AND ");
            Filter.Append($"sale.sale_status = '{status}'");
        }
        public void FilterByDate(string date)
        {
            if(Filter.Length>0) Filter.Append(" AND ");
            Filter.Append($"sale.sale_date = '{date}'");
        }
        public void FilterByDates(string date1, string date2)
        {
            if (Filter.Length > 0) Filter.Append(" AND ");
            Filter.Append($"sale.sale_date BETWEEN '{date1}' AND '{date2}'");
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
                foreach (var item in SalesList)
                {
                    if (item.Id == -1 && item.IsDelete) continue;
                    if (item.Id == -1)
                    {
                        SaleApi.AddSale(item.PassportCar.Id, item.Employee.Id, item.Cost, item.CarBuyer?.Id, item.Date?.ToString("dd/MM/yyyy") ?? "", item.Status);
                    }
                    else if (item.IsDelete)
                    {
                        SaleApi.DeleteSale(item.Id);
                    }
                    else if (item.IsEdited)
                    {
                        SaleApi.UpdateSale(item.Id, item.PassportCar.Id, item.Employee.Id, item.Cost, item.CarBuyer?.Id, item.Date?.ToString("dd/MM/yyyy") ?? "", item.Status);
                    }
                }
                return true;
            }
            catch { return false; }
            finally { DataBase.CloseConnection(); }
        }
    }
}
