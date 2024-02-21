using Ages_The_Game.Models;

namespace Ages_The_Game.Repositorio.Interface
{
    public interface IImagensRepositorio
    {
        Task<List<ImagensModels>> BuscarTodasImagens();
        Task<ImagensModels> BuscarPorId(int id);
        Task<ImagensModels> Adicionar(ImagensModels imagem);
        Task<ImagensModels> Atualizar(ImagensModels imagem, int id);
        Task<bool> Apagar(int id);
    }
}
