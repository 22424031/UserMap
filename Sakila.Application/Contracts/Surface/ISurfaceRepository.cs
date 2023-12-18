using Sakila.Domain;
namespace Sakila.Application.Contracts.Citys
{
    public interface ISurfaceRepository: IGenericRepository<Surfaces>
    {
        Task<Surfaces> SearchCity(string cityname);
        Task<List<Surfaces>> GetListBySpaceID(int id);
    }
}
