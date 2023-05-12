namespace CarDealershipApp.Entity
{
    internal class Car
    {
        private string _Trademark;
        private string _Model;
        private string _Series;

        public int Id { set; get; }
        public string Trademark { set { _Trademark = value; if ( Id != -1) IsEdited = true; } get { return _Trademark; } }
        public string Model { set { _Model = value; if (Id != -1) IsEdited = true; } get { return _Model; } }
        public string Series { set { _Series = value; if (Id != -1) IsEdited = true; } get { return _Series; } }

        public bool IsEdited { set; get; }
        public bool IsDelete { set; get; }

        public Car(int Id, string Trademark, string Model, string Series)
        {
            this.Id = Id;
            this._Trademark = Trademark;
            this._Model = Model;
            this._Series = Series;
            this.IsEdited = false;
            this.IsDelete = false;
        }
        public string GetFullName() => Trademark + " " + Model;
    }
}
