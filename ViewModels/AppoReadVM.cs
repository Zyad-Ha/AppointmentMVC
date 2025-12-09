using AppointmentMVC.Models;


namespace AppointmentMVC.ViewModels
{
    public class AppoReadVM
    {
        public int Id { get; set; }
        public DateTime AppoDateTime { get; set; }
        public int DurationByMinuts { get; set; }
        public Status Status { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set; }
        public Patient Patient { get; set; }
    }
}
