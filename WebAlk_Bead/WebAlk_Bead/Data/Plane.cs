using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAlk_Bead.Data
{
    [Index(nameof(Callsign), IsUnique = true)]
    public class Plane
    {
        public int PlaneId { get; set; }
        [RegularExpression(@"^[A-Z]{1,2}[1-9]{1}[0-9]{2}[A-Z]{0,1}$", ErrorMessage = "Wrong Plane Name format.")]
        public string PlaneName { get; set; }
        [RegularExpression(@"^[A-Z]{2,6}-[0-9]{1}[0-9]{1}$", ErrorMessage = "Wrong Plane Callsign format.")]
        public string Callsign { get; set; }
        [RegularExpression(@"^[2-9]$|^[0-9]{2,3}$", ErrorMessage = "Wrong number of seats.")]
        public int? NumberOfSeats { get; set; }
        [RegularExpression(@"^[2-9]$", ErrorMessage = "Wrong number of Crew.")]
        public int? NumberOfCrew { get; set; }
        public int? FlightId { get; set; }
        public Flight Flight { get; set; }
        public override string ToString()
        {
            return "Plane: " + PlaneName + " " + Callsign + " " + NumberOfSeats + " " + NumberOfCrew;
        }
    }
}
