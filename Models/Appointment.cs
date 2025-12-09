using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentMVC.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public int DocID { get; set; }
        [ForeignKey(nameof(DocID))]
        public Doctor Doctor { get; set; }
        public int PatientID { get; set; }
        [ForeignKey(nameof(PatientID))]
        public Patient Patient { get; set; }
        public DateTime AppoDateTime { get; set; }
        public int DurationByMinuts { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Scheduled,
        Completed,
        Cancelled
    }
}
