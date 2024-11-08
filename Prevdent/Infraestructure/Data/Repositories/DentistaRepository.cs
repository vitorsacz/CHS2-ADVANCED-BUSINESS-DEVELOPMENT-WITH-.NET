using Prevdent.Domain.Entities;
using Prevdent.Infraestructure.Data.AppData;
using Microsoft.EntityFrameworkCore;

namespace Prevdent.Infraestructure.Data.Repositories;

public class DentistaRepository : IDentistaRepository
{
    private readonly ApplicationContext _context;

    public DentistaRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<DentistaEntity> GetAllDentistas()
    {
        return _context.Set<DentistaEntity>().ToList();
    }

    public DentistaEntity GetDentistaById(int id)
    {
        return _context.Set<DentistaEntity>().Find(id);
    }

    public DentistaEntity GetDentistaByCro(string cro)
    {
        return _context.Set<DentistaEntity>().FirstOrDefault(d => d.CRO == cro);
    }

    public DentistaEntity AddDentista(DentistaEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public DentistaEntity DeleteDentistaById(int id)
    {
        var entity = _context.Set<DentistaEntity>().Find(id);
        if (entity != null)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        return entity;
    }

    public DentistaEntity UpdateDentistaById(int id, DentistaEntity entity)
    {
        var existingEntity = _context.Set<DentistaEntity>().Find(id);

        if (existingEntity != null)
        {
            existingEntity.Nome = entity.Nome;
            existingEntity.Email = entity.Email;
            existingEntity.CPF = entity.CPF;
            existingEntity.CRO = entity.CRO;

            _context.Entry(existingEntity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        return existingEntity;
    }
}
