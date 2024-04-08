namespace C03.CallingViews.Entities
{
    public class EmployeePerformanceSummary
    {
        public string? Employee { get; set; }
        public int TotalAppointments { get; set; }
        public string? JobTitle { get; set; }

        public override string ToString()
        {
            return $"{Employee} {JobTitle} {TotalAppointments}";
        }
    }
}
