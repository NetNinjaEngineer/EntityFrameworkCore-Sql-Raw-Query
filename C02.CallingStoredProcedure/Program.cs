using C02.CallingStoredProcedure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace C02.CallingStoredProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                #region Call Stored Procedure
                var fullNameParam = new SqlParameter("@fullName", System.Data.SqlDbType.VarChar)
                {
                    Value = "Mohamed"
                };

                var patients = context.PatientsDetails.FromSql($"EXEC [dbo].[GetPatientsByFullName] {fullNameParam}");

                foreach (var patient in patients)
                    Console.WriteLine(patient);

                #endregion

            }
        }
    }
}
