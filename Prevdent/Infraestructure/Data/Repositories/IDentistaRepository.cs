using Prevdent.Domain.Entities;

namespace Prevdent.Infraestructure.Data.Repositories;

public interface IDentistaRepository
{
    IEnumerable<DentistaEntity> GetAllDentistas();
    DentistaEntity GetDentistaById(int id);
    DentistaEntity GetDentistaByCro(string cro);
    DentistaEntity AddDentista(DentistaEntity entity);
    DentistaEntity UpdateDentistaById(int id, DentistaEntity entity);
    DentistaEntity DeleteDentistaById(int id);
}
