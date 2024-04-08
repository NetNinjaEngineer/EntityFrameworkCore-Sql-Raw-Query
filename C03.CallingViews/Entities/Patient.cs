using C02.CallingStoredProcedure.Entities.Common;

namespace C02.CallingStoredProcedure.Entities
{
    public class Patient : Person
    {
        public string? Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = [];
    }
}
