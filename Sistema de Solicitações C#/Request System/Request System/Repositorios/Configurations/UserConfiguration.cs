using System.Data.Entity.ModelConfiguration;

namespace Request_System.Repositorios.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<Entities.User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            HasKey(s => s.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.CPF)
                .IsOptional()
                .HasMaxLength(20);

            Property(p => p.Email)
                .IsOptional()
                .HasMaxLength(255);

            Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Password)
                .IsRequired();

            Property(p => p.IsActive)
                .IsRequired();

            Property(p => p.Setor)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Type)
                .IsRequired();

            Property(p => p.InsertDate)
                .IsRequired();
        }
    }
}
