using C02.CallingStoredProcedure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C02.CallingStoredProcedure.Data.Config
{
    public class PatientsDetailsConfiguration : IEntityTypeConfiguration<PatientsDetails>
    {
        public void Configure(EntityTypeBuilder<PatientsDetails> builder)
        {
            builder.HasNoKey();
        }
    }
}
