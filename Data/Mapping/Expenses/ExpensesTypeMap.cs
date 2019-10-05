using Expenses.Entities.Expenses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expenses.Data.Mapping.Expenses
{
    public class ExpensesTypeMap : IEntityTypeConfiguration<ExpensesType>
    {
        public void Configure(EntityTypeBuilder<ExpensesType> builder)
        {
            builder.ToTable("expensesType")
                .HasKey(t => t.idTypeExpenses);
            builder.Property(t => t.nameTypeExpenses)
                 .HasMaxLength(50);
            builder.Property(t => t.descriptionTypeExpenses)
                .HasMaxLength(256);
        }
    }
}
