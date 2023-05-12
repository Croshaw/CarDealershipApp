namespace CarDealershipApp.Entity
{
    internal class Position
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Position(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
