using AppointmentMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentMVC.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options): base (options) { }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient>  patients { get; set; }
        public DbSet<Appointment> appointments  { get; set; }

    }
}
