namespace Smart_Building1.Model
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}
