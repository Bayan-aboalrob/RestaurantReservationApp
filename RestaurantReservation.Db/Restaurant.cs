using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string OpeningHours { get; set; }

        public List<Employee> Employees { get; set; }

        public List<MenuItem> MenuItems { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<Table> Tables { get; set; }

        public Restaurant()
        {
            Employees = new List<Employee>();
            MenuItems = new List<MenuItem>();
            Reservations = new List<Reservation>();
            Tables = new List<Table>();
        }
    }
}
