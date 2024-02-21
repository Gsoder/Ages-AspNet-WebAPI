using Ages_The_Game.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Ages_The_Game.Data.Map
{
    public class ListaImagensMap : IEntityTypeConfiguration<ListaImagensModels>
    {
        public void Configure(EntityTypeBuilder<ListaImagensModels> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(l => l.ImagemDoDia).WithOne().HasForeignKey(i => i.IDDaLista);

        }
    }
}
