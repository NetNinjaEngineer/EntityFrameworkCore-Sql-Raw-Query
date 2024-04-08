namespace C04.CallingFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext context = new())
            {
                #region Calling Views
                var employeesPerformance = context.EmployeePerformanceSummaryView.ToList();
                foreach (var item in employeesPerformance)
                    Console.WriteLine(item);
                #endregion

            }

            Console.ReadKey();
        }
    }
}
