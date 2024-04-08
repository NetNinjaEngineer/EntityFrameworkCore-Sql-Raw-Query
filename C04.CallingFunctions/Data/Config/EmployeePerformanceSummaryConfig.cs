using C03.CallingViews.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C03.CallingViews.Data.Config
{
    public class EmployeePerformanceSummaryConfig : IEntityTypeConfiguration<EmployeePerformanceSummary>
    {
        public void Configure(EntityTypeBuilder<EmployeePerformanceSummary> builder)
        {
            builder.HasNoKey();
            builder.ToView("EmployeePerformanceSummary");
        }
    }
}
