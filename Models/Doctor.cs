using System.ComponentModel.DataAnnotations;

namespace AppointmentMVC.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
    }
}
