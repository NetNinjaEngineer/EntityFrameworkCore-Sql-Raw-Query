namespace C02.CallingStoredProcedure.Entities
{
    public class PatientsDetails
    {
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Phone { get; set; }

        public string? Gender { get; set; }

        public override string ToString()
            => $"{string.Concat(FirstName, " ", LastName)}" +
                $"\nMail: {Email}" +
                $"\nPhone: {Phone}";
    }
}
