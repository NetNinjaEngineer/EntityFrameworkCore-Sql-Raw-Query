using C01.SqlQuery.Entities.Common;

namespace C01.SqlQuery.Entities
{
    public class Patient : Person
    {
        public string? Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = [];
    }
}
