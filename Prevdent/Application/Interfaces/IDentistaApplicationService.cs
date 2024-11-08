using Prevdent.Application.DTOs;
using Prevdent.Domain.Entities;

namespace Prevdent.Application.Interfaces
{
    public interface IDentistaApplicationService
    {
        IEnumerable<DentistaEntity> GetAll();
        DentistaEntity GetById(int id);
        DentistaEntity GetByCro(string cro);
        DentistaEntity Add(DentistaDTO dentistaDTO);
        DentistaEntity Update(int id, DentistaDTO dentistaDTO);
        DentistaEntity DeleteById(int id);
    }
}
