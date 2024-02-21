using Ages_The_Game.Models;

namespace Ages_The_Game.Repositorio.Interface
{
    public interface IListaImagemRepositorio
    {
        Task<List<ListaImagensModels>> BuscarTodosItens();
        Task<ListaImagensModels> BuscarPorId(int id);
        Task<ListaImagensModels> Adicionar(ListaImagensModels imagem);
        Task<ListaImagensModels> Atualizar(ListaImagensModels imagem, int id);
        Task<bool> Apagar(int id);
    }
}
