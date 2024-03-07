namespace Smart_Building1.Model
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public ICollection<CitizenApartment> CitizenApartments { get; set; }
    }
}
