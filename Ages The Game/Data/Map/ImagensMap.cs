using Ages_The_Game.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ages_The_Game.Data.Map
{
    public class ImagensMap : IEntityTypeConfiguration<ImagensModels>
    {
        public void Configure(EntityTypeBuilder<ImagensModels> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Base64Imagem).IsRequired();
            builder.Property(x => x.Ano).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Pais).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Continente).IsRequired().HasMaxLength(20);
            builder.Property(x => x.IDDaLista).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Dica1).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Dica2).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Dica3).IsRequired().HasMaxLength(60);
 
        }
    }
}
