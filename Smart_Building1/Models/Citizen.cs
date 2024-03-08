using System.ComponentModel.DataAnnotations;

namespace Smart_Building1.Model
{
    public class Citizen
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<CitizenApartment>? CitizenApartments { get; set; }
    }
}
