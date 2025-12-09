using AppointmentMVC.Models;

namespace AppointmentMVC.ViewModels
{
    public class PatientsAppoViewModel
    {
        public Patient Patient{ get; set; }
        public IEnumerable<AppoViewModel> appoViewModelss { get; set; }
    }
}
