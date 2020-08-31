using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Testing.Models.Configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);
            
            entityBuilder.Property(x => x.MiddleName)
                .HasMaxLength(150);

            entityBuilder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(150);

            entityBuilder.Property(x => x.SecondLastName)
                .IsRequired()
                .HasMaxLength(150);
            
            entityBuilder.Property(x => x.Email)
                .HasMaxLength(100);
            
        }
    }
}