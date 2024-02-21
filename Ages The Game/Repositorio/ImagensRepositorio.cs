using Ages_The_Game.Data;
using Ages_The_Game.Models;
using Ages_The_Game.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;

namespace Ages_The_Game.Repositorio
{
    public class ImagemRepositorio : IImagensRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public ImagemRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ImagensModels> Adicionar(ImagensModels imagem)
        {
            await _appDbContext.ItensDaLista.AddAsync(imagem);
            await _appDbContext.SaveChangesAsync();

            return imagem;
        }

        public async Task<bool> Apagar(int id)
        {
            ImagensModels imagensPorId = await BuscarPorId(id);

            if(imagensPorId == null) {
                throw new Exception($"Imagem não encontrada id: {id}");
            }
            _appDbContext.ItensDaLista.Remove(imagensPorId);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ImagensModels> Atualizar(ImagensModels imagem, int id)
        {
            ImagensModels imagensPorId = await BuscarPorId(id);

            if (imagensPorId == null)
            {
                throw new Exception($"lista não foi encontrado id: {id}");
            }

            imagensPorId.Id = imagem.Id;
            imagensPorId.Base64Imagem = imagem.Base64Imagem;
            imagensPorId.Ano = imagem.Ano;
            imagensPorId.Pais = imagem.Pais;
            imagensPorId.Continente = imagem.Continente;
            imagensPorId.IDDaLista = imagem.IDDaLista;
            imagensPorId.Dica1 = imagem.Dica1;
            imagensPorId.Dica2 = imagem.Dica2;
            imagensPorId.Dica3 = imagem.Dica3;


            _appDbContext.ItensDaLista.Update(imagensPorId);
            await _appDbContext.SaveChangesAsync();

            return imagensPorId;
        }

        public async Task<ImagensModels> BuscarPorId(int id)
        {
            return await _appDbContext.ItensDaLista.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ImagensModels>> BuscarTodasImagens()
        {
            return await _appDbContext.ItensDaLista.ToListAsync();
        }
    }
}
