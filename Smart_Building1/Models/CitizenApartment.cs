namespace Smart_Building1.Model
{
    public class CitizenApartment
    {
        public int CitizenId { get; set; }
        public Citizen Citizen { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
