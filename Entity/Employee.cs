namespace CarDealershipApp.Entity
{

    internal class Employee : People
    {
        private Position _Position;
        public Position Position { set { _Position = value; if (Id != -1) IsEdited = true; } get { return _Position; } }
        public Employee(int Id, string Surname, string Name, string Patronymic, string Phone, DateTime BirthDate, Position Position, string Address) : base(Id, Surname, Name, Patronymic, Phone, BirthDate, Address)
        {
            this._Position = Position;
        }
    }
}
