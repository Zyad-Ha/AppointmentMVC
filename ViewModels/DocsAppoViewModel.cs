using AppointmentMVC.Models;

namespace AppointmentMVC.ViewModels
{
    public class DocsAppoViewModel
    {
        public Doctor Doctor { get; set; }
        public IEnumerable<AppoViewModel> appoViewModels { get; set; }
    }
}
