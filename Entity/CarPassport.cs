namespace CarDealershipApp.Entity
{
    internal class CarPassport
    {
        private Car _Car;
        private People _Owner;
        private string _Number; 

        public int Id { set; get; }
        public Car Car { set { _Car = value; if (Id != -1) IsEdited = true; } get { return _Car; } }
        public People Owner { set { _Owner = value; if (Id != -1) IsEdited = true; } get { return _Owner; } }
        public string Number { set { _Number = value; if (Id != -1) IsEdited = true; } get { return _Number; } }
        public bool IsEdited { set; get; }
        public bool IsDelete { set; get; }

        public CarPassport(int Id, Car Car, People Owner, string Number)
        {
            this.Id = Id;
            this._Car = Car;
            this._Owner = Owner;
            this._Number = Number;
            this.IsEdited = false;
            this.IsDelete = false;
        }
    }
}
