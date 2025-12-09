using AppointmentMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentMVC.ViewModels
{
    public class AppoViewModel
    {
        [Key]
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppoDateTime { get; set; }
        public int DurationByMinuts { get; set; }
        public Status Status { get; set; }
    }
}
