using C02.CallingStoredProcedure.Data;
using Microsoft.EntityFrameworkCore;

namespace C04.CallingFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext context = new())
            {
                #region Calling Functions
                var doctors = context.Employees
                    .Where(e => e.JobTitle.ToLower() == "doctor")
                    .Include(e => e.Department)
                    .Select(e => new
                    {
                        EmpId = e.Id,
                        Fullname = string.Concat(e.FirstName, " ", e.LastName),
                        EmpDepartment = e.Department.Name,
                        JobTitle = e.JobTitle,
                        Contact = e.Phone,
                        Availability = ApplicationDbContext.GetDoctorAvailability(e.Id, (int)DayOfWeek.Monday)
                    });

                foreach (var emp in doctors)
                    Console.WriteLine($"[{emp.EmpId}]  {emp.Fullname} - ({emp.JobTitle})" +
                        $"{emp.EmpDepartment} - " +
                        $"{emp.Contact} - ({emp.Availability})");

                #endregion

            }

            Console.ReadKey();
        }
    }
}
