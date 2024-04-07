using C01.SqlQuery.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace C01.SqlQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                #region FromSql ef(7.0) (Use Parameters By Default)
                //var patients = context.Patients.FromSql($"SELECT * FROM Patients");
                //foreach (var patient in patients)
                //    Console.WriteLine($"" +
                //        $"\nFullname: {string.Concat(patient.FirstName, " ", patient.LastName)}" +
                //        $"\nGender: {patient.Gender}" +
                //        $"\nEmail: {patient.Email}" +
                //        $"\nPhone: {patient.Phone}");

                //var patient = context.Patients.FromSql($"SELECT * FROM Patients WHERE Id = {1}")
                //    .FirstOrDefault();

                //Console.WriteLine($"{string.Concat(patient.FirstName, " ", patient.LastName)} Mail: [{patient.Email}]");


                #endregion

                #region FromSqlInterpolated (Use Parameters By Default)
                //var employees = context.Employees.FromSqlInterpolated($"SELECT * FROM Employees");
                //foreach (var employee in employees)
                //    Console.WriteLine($"{string.Concat(employee.FirstName, " ", employee.LastName)} [{employee.JobTitle}]");

                //var patient = context.Patients.FromSqlInterpolated($"SELECT * FROM Patients WHERE Id = {1}")
                //      .FirstOrDefault();

                //Console.WriteLine($"{string.Concat(patient.FirstName, " ", patient.LastName)} Mail: [{patient.Email}]");

                #endregion

                #region FromSqlRaw (Not Use Parameters By Default =====> Sql Injection)
                //var employees = context.Employees.FromSqlRaw("SELECT * FROM Employees");
                //foreach (var employee in employees)
                //    Console.WriteLine($"{string.Concat(employee.FirstName, " ", employee.LastName)} [{employee.JobTitle}]");

                var patientIdParam = new SqlParameter("@patientId", 1);
                var patient = context.Patients.FromSqlRaw("SELECT * FROM Patients WHERE Id = @patientId", patientIdParam)
                    .FirstOrDefault();

                if (patient != null)
                    Console.WriteLine($"{string.Concat(patient.FirstName, " ", patient.LastName)}  " +
                        $"Mail: [{patient.Email}]");


                #endregion
            }

            Console.ReadKey();
        }
    }
}
