using System.ComponentModel.DataAnnotations;

namespace AppointmentMVC.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
    }
}
