using System.ComponentModel.DataAnnotations;

namespace AppointmentMVC.ViewModels
{
    public class PatientsViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
