using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAlk_Bead.Data
{
    [Index(nameof(FlightNumber), IsUnique = true)]
    public class Flight
    {
        public int FlightId { get; set; }
        [RegularExpression(@"^[A-Z]{2,3}-[1-9]{1}[0-9]{2,3}$", ErrorMessage = "Wrong Plane Number format.")]
        public string FlightNumber { get; set; }
        [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = "Wrong From format.")]
        public string From { get; set; }
        [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = "Wrong To format.")]
        public string To { get; set; }
        [RegularExpression(@"^[G]-[0-9]{2}$", ErrorMessage = "Wrong Gate format.")]
        public string? Gate { get; set; }
        public string? Airline { get; set; }
        public string? Status { get; set; }
        public List<Plane> Planes { get; } = new();

        public override string ToString()
        {
            return "Flight: " + FlightNumber + " " + From + " " + To + " " + Gate + " " + Airline + " ";
        }
    }
}
