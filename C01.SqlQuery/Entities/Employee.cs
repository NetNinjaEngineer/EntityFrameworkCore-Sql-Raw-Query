using C01.SqlQuery.Entities.Common;

namespace C01.SqlQuery.Entities
{
    public class Employee : Person
    {
        public string? JobTitle { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = [];

        public override string ToString()
        {
            return $"{string.Concat(FirstName, ' ', LastName)} - {JobTitle} ({Department.Name})";
        }

    }
}
