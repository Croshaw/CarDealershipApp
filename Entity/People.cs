namespace CarDealershipApp.Entity
{
    internal class People
    {
        private string _Surname;
        private string _Name;
        private string _Patronymic;
        private string _Phone;
        private DateTime _BirthDate;
        private string _Address;

        public int Id { set; get; }
        public string Surname { set { _Surname = value; if (Id != -1) IsEdited = true; } get { return _Surname; } }
        public string Name { set { _Name = value; if (Id != -1) IsEdited = true; } get { return _Name; } }
        public string Patronymic { set { _Patronymic = value; if (Id != -1) IsEdited = true; } get { return _Patronymic; } }
        public string Phone { set { _Phone = value; if (Id != -1) IsEdited = true; } get { return _Phone; } }
        public DateTime BirthDate { set { _BirthDate = value; if (Id != -1) IsEdited = true; } get { return _BirthDate; } }
        public string Address { set { _Address = value; if (Id != -1) IsEdited = true; } get { return _Address; } }
        public bool IsEdited { set; get; }
        public bool IsDelete { set; get; }

        public People(int Id, string Surname, string Name, string Patronymic, string Phone, DateTime BirthDate, string Address)
        {
            this.Id = Id;
            this._Surname = Surname;
            this._Name = Name;
            this._Patronymic = Patronymic;
            this._Phone = Phone;
            this._BirthDate = BirthDate;
            this._Address = Address;
            this.IsEdited = false;
            this.IsDelete = false;
        }

        public string GetFullName() => Surname + " " + Name[0] + ". " + Patronymic[0] + ".";
    }
}
