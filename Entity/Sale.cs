namespace CarDealershipApp.Entity
{
    internal class Sale
    {
        private CarPassport _PassportCar;
        private Employee _Employee;
        private long _Cost;
        private People? _CarBuyer;
        private DateTime? _Date;
        private string _Status;
        public int Id { set; get; }
        public CarPassport PassportCar { set { _PassportCar = value; if (Id != -1) IsEdited = true; } get { return _PassportCar; } }
        public Employee Employee { set { _Employee = value; if (Id != -1) IsEdited = true; } get { return _Employee; } }
        public long Cost { set { _Cost = value; if (Id != -1) IsEdited = true; } get { return _Cost; } }
        public People? CarBuyer { set { _CarBuyer = value; if (Id != -1) IsEdited = true; } get { return _CarBuyer; } }
        public DateTime? Date { set { _Date = value; if (Id != -1) IsEdited = true; } get { return _Date; } }
        public string Status { set { _Status = value; if (Id != -1) IsEdited = true; } get { return _Status; } }
        public bool IsEdited { set; get; }
        public bool IsDelete { set; get; }

        public Sale(int Id, CarPassport passportCar, Employee employee, long cost, People? carBuyer, DateTime? date)
        {
            this.Id = Id;
            this._PassportCar = passportCar;
            this._Employee = employee;
            this._Cost = cost;
            this._CarBuyer = carBuyer;
            if (carBuyer == null)
            {
                this._Status = "Продаётся";
                this._Date = null;
            }
            else
            {
                this._Status = "Продано";
                this._Date = date;
            }
            this.IsEdited = false;
            this.IsDelete = false;
        }
        public Sale(int Id, CarPassport passportCar, Employee employee, long cost, People? carBuyer, DateTime? date, string status):this(Id, passportCar, employee, cost, carBuyer, date)
        {
            if(!string.IsNullOrEmpty(status))
                this._Status = status;
        }
    }
}
