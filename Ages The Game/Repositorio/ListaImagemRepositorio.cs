using Ages_The_Game.Data;
using Ages_The_Game.Models;
using Ages_The_Game.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;

namespace Ages_The_Game.Repositorio
{
    public class ListaImagemRepositorio : IListaImagemRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public ListaImagemRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ListaImagensModels> Adicionar(ListaImagensModels imagem)
        {
            await _appDbContext.Lista.AddAsync(imagem);
            await _appDbContext.SaveChangesAsync();

            return imagem;
        }

        public async Task<bool> Apagar(int id)
        {
            ListaImagensModels listaPorId = await BuscarPorId(id);

            if (listaPorId == null)
            {
                throw new Exception($"Imagem não encontrada id: {id}");
            }
            _appDbContext.Lista.Remove(listaPorId);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ListaImagensModels> Atualizar(ListaImagensModels imagem, int id)
        {
            ListaImagensModels imagensPorId = await BuscarPorId(id);

            if (imagensPorId == null)
            {
                throw new Exception($"lista não foi encontrado id: {id}");
            }

            imagensPorId.Id = imagem.Id;
            imagensPorId.ImagemDoDia = imagem.ImagemDoDia;


            _appDbContext.Lista.Update(imagensPorId);
            await _appDbContext.SaveChangesAsync();

            return imagensPorId;
        }

        public async Task<ListaImagensModels> BuscarPorId(int id)
        {
            return await _appDbContext.Lista
                .Include(x => x.ImagemDoDia)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ListaImagensModels>> BuscarTodosItens()
        {
            return await _appDbContext.Lista.Include(x => x.ImagemDoDia).ToListAsync();
        }
    }
}
